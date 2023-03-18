using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;

namespace ServerBrowser
{
  class GeoIpClient
  {
    internal const int ThreadCount = 7;
    // Ipinfo.io API can be used without token, but unauthenticated API daily usage is limited to 100 requests. Free account is limited to 50k requests/month.
    // To use account token, add it as value of "IpInfoApiKey" key in ServerBrowser.ini
    public string IpInfoToken = ""; // create an IpInfo account and get token at https://ipinfo.io/account/home
    private const string DefaultServiceUrlFormat = "https://ipinfo.io/{0}/json?token={1}";
    private DateTime usageExceeded = DateTime.MinValue;

    /// <summary>
    /// the cache holds either a GeoInfo object, or a multicast callback delegate waiting for a GeoInfo object
    /// </summary>
    private readonly Dictionary<uint,object> cache = new Dictionary<uint, object>();
    private readonly BlockingCollection<IPAddress> queue = new BlockingCollection<IPAddress>();
    private readonly string cacheFile;

    public string ServiceUrlFormat { get; set; }

    public GeoIpClient(string cacheFile)
    {
      this.cacheFile = cacheFile;
      this.ServiceUrlFormat = DefaultServiceUrlFormat;
      for (int i=0; i<ThreadCount; i++)
        ThreadPool.QueueUserWorkItem(context => this.ProcessLoop());
    }

    #region ProcessLoop()
    private void ProcessLoop()
    {
      using (var client = new XWebClient(5000))
      {
        while (true)
        {
          var ip = this.queue.Take();
          if (ip == null)
            break;

          bool err = true;
          var ipInt = Ip4Utils.ToInt(ip);
          try
          {
            var url = string.Format(this.ServiceUrlFormat, ip, IpInfoToken);
            var result = client.DownloadString(url);
            if (result != null)
            {
              object o;
              Action<GeoInfo> callbacks;
              lock (cache)
                callbacks = cache.TryGetValue(ipInt, out o) ? o as Action<GeoInfo> : null;
              var geoInfo = this.HandleResult(ipInt, result);
              if (callbacks != null && geoInfo != null)
                ThreadPool.QueueUserWorkItem(ctx => callbacks(geoInfo));
              err = false;
            }
          }
          catch
          {
            // ignore
          }

          if (err)
          { 
            lock (this.cache)
              this.cache.Remove(ipInt);
          }
        }
      }
    }
    #endregion

    #region HandleResult()
    private GeoInfo HandleResult(uint ip, string result)
    {
      var ser = new DataContractJsonSerializer(typeof(IpInfoIpFullResponse));
      var info = (IpInfoIpFullResponse)ser.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(result)));

      if (info.status == 429)
      {
        this.usageExceeded = DateTime.UtcNow.Date;
        lock (cache)
          this.cache.Remove(ip);
        return null;
      }

      if (info.bogon)
      {
        lock (cache)
          this.cache.Remove(ip);
        return null;
      }

      var geoInfo = new GeoInfo(info.country, info.region, info.city);
      lock (cache)
      {
        cache[ip] = geoInfo;
      }
      return geoInfo;
    }
    #endregion

    #region TryGet()
    private string TryGet(IDictionary<string,string> dict, string key)
    {
      string ret;
      return dict != null && dict.TryGetValue(key, out ret) ? ret : null;
    }
    #endregion

    #region Lookup()
    public void Lookup(IPAddress ip, Action<GeoInfo> callback)
    {
      uint ipInt = Ip4Utils.ToInt(ip);
      GeoInfo geoInfo = null;
      lock (cache)
      {
        if (cache.TryGetValue(ipInt, out var cached))
          geoInfo = cached as GeoInfo;

        if (geoInfo == null)
        {
          if (this.usageExceeded == DateTime.UtcNow.Date)
            return;

          if (cached == null)
          {
            cache.Add(ipInt, callback);
            this.queue.Add(ip);
          }
          else
          {
            var callbacks = (Action<GeoInfo>) cached;
            callbacks += callback;
            cache[ipInt] = callbacks;
          }
          return;
        }
      }
      callback(geoInfo);    
    }
    #endregion

    #region CancelPendingRequests()
    public void CancelPendingRequests()
    {
      IPAddress item;
      while (this.queue.TryTake(out item))
      {        
      }

      lock (cache)
      {
        var keys = cache.Keys.ToList();
        foreach (var key in keys)
        {
          if (!(cache[key] is GeoInfo))
            cache.Remove(key);
        }
      }
    }
    #endregion

    #region LoadCache()
    public void LoadCache()
    {
      if (!File.Exists(this.cacheFile))
        return;
      lock (cache)
      {
        foreach (var line in File.ReadAllLines(this.cacheFile))
        {
          try
          {
            var parts = line.Split(new[] {'='}, 2);
            uint ipInt = 0;
            var octets = parts[0].Split('.');
            foreach (var octet in octets)
              ipInt = (ipInt << 8) + uint.Parse(octet);
            var loc = parts[1].Split('|');
            var countryCode = loc[0];
            if (countryCode != "")
            {
              var geoInfo = new GeoInfo(countryCode, loc[1], loc[2]);
              cache[ipInt] = geoInfo;
            }
          }
          catch
          {
            // ignore
          }
        }
      }
    }
    #endregion

    #region SaveCache()
    public void SaveCache()
    {
      try
      {
        var sb = new StringBuilder();
        lock (this.cache)
        {
          foreach (var entry in this.cache)
          {
            var ip = entry.Key;
            var info = entry.Value as GeoInfo;
            if (info == null) continue;
            sb.AppendFormat("{0}.{1}.{2}.{3}={4}|{5}|{6}\n",
              ip >> 24, (ip >> 16) & 0xFF, (ip >> 8) & 0xFF, ip & 0xFF,
              info.Iso2, info.Region, info.City);
          }
        }
        File.WriteAllText(this.cacheFile, sb.ToString());
      }
      catch { }
    }
    #endregion
  }

  #region class GeoInfo
  public class GeoInfo
  {
    public string Iso2 { get; }
    public string Region { get; }
    public string City { get; }

    public GeoInfo(string iso2, string region, string city)
    {
      this.Iso2 = iso2;
      this.Region = region;
      this.City = city;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(Iso2);
      if (!string.IsNullOrEmpty(Region))
        sb.Append(", ").Append(Region);
      if (!string.IsNullOrEmpty(City))
        sb.Append(", ").Append(City);
      return sb.ToString();
    }

  }
  #endregion

  #region class IpInfoIpFullResponse
  public class IpInfoIpFullResponse
  {
    public int status;
        
    public string ip;
    public bool bogon;

    public string hostname;
    public string city;
    public string region;
    public string country;
    public string loc;
    public string org;
    public string postal;
    public string timezone;
    public string readme;
  }
  #endregion

}
