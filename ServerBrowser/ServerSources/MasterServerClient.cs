using System.Net;
using QueryMaster;

namespace ServerBrowser
{
  public class MasterServerClient : IServerSource
  {
    private readonly IPEndPoint masterServerEndPoint;
    private readonly string SteamWebApiKey;

    public MasterServerClient(IPEndPoint masterServerEndpoint, string SteamWebApiKey)
    {
      this.masterServerEndPoint = masterServerEndpoint;
      this.SteamWebApiKey = SteamWebApiKey;
    }

    public void GetAddresses(Region region, IpFilter filter, int maxResults, MasterIpCallback callback)
    {
      var master = masterServerEndPoint?.Port == null ? (MasterServer)new MasterServerWebApi(SteamWebApiKey) : new MasterServerUdp(masterServerEndPoint);
      master.GetAddressesLimit = maxResults;
      master.GetAddresses(region, callback, filter);
    }
  }
}