﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QueryMaster;

namespace ServerBrowser
{
  class TabViewModel
  {
    private List<ServerRow> servers;
    internal ServerRow lastSelectedServer;
    internal ServerRow currentServer;
    internal IServerSource serverSource;
    internal GameExtension gameExtension;

    public enum SourceType { MasterServer, CustomList, Favorites }

    public string Caption { get; set; }
    public string MasterServer { get; set; }
    public int InitialGameID { get; set; }
    public string FilterMod { get; set; }
    public string FilterIP { get; set; }
    public string BlockedIPs { get; set; }
    public string FilterMap { get; set; }
    public string MapsExcludeServer { get; set; }
    public string TagsIncludeServer { get; set; }
    public string TagsExcludeServer { get; set; }
    public string NamesIncludeServer { get; set; }
    public string NamesExcludeServer { get; set; }
    public bool GetEmptyServers { get; set; }
    public bool GetFullServers { get; set; }
    public bool GetOfficialServers { get; set; }
    public int MasterServerQueryLimit { get; set; }

    public int MinPlayers { get; set; }
    public bool MinPlayersInclBots { get; set; }
    public int MaxPing { get; set; }
    public string GridFilter { get; set; }
    public string TagsIncludeClient { get; set; }
    public string TagsExcludeClient { get; set; }
    public string VersionMatch { get; set; }

    public MemoryStream ServerGridLayout { get; set; }
    public SourceType Source { get; set; }
    public int ImageIndex => Source == SourceType.Favorites ? 3 : Source == SourceType.CustomList ? 12 : -1;
    public List<string> CustomDetailColumns { get; } = new List<string>();
    public List<string> CustomRuleColumns { get; } = new List<string>();
    public List<string> HideColumns { get; } = new List<string>();

    public TabViewModel()
    {
      this.GetEmptyServers = true;
      this.GetFullServers = true;
      this.GetOfficialServers = true;
      this.MasterServerQueryLimit = 1000;
    }

    public List<ServerRow> Servers
    {
      get { return this.servers; }
      set
      {
        if (value == this.servers) return;
        this.servers = value;
        if (!this.servers.Contains(lastSelectedServer))
          this.lastSelectedServer = null;
        if (!this.servers.Contains(currentServer))
          this.currentServer = null;
      }
    }

    #region AssignFrom()
    public void AssignFrom(TabViewModel opt)
    {
      this.MasterServer = opt.MasterServer;
      this.InitialGameID = opt.InitialGameID;
      this.FilterMod = opt.FilterMod;
      this.FilterIP = opt.FilterIP;
      this.BlockedIPs = opt.BlockedIPs;
      this.FilterMap = opt.FilterMap;
      this.MapsExcludeServer = opt.MapsExcludeServer;
      this.TagsIncludeServer = opt.TagsIncludeServer;
      this.TagsExcludeServer = opt.TagsExcludeServer;
      this.NamesIncludeServer = opt.NamesIncludeServer;
      this.NamesExcludeServer = opt.NamesExcludeServer;
      this.GetEmptyServers = opt.GetEmptyServers;
      this.GetFullServers = opt.GetFullServers;
      this.GetOfficialServers = opt.GetOfficialServers;
      this.MasterServerQueryLimit = opt.MasterServerQueryLimit;

      this.Source = opt.Source;
      this.serverSource = opt.serverSource;
      this.Servers = new List<ServerRow>(opt.Servers);
      this.gameExtension = opt.gameExtension;
      this.GridFilter = opt.GridFilter;
      this.MinPlayers = opt.MinPlayers;
      this.MinPlayersInclBots = opt.MinPlayersInclBots;
      this.MaxPing = opt.MaxPing;
      this.TagsIncludeClient = opt.TagsIncludeClient;
      this.TagsExcludeClient = opt.TagsExcludeClient;
      this.ServerGridLayout = opt.ServerGridLayout;
      this.VersionMatch = opt.VersionMatch;
      this.CustomDetailColumns.AddRange(opt.CustomDetailColumns);
      this.CustomRuleColumns.AddRange(opt.CustomRuleColumns);
      this.HideColumns.AddRange(opt.HideColumns);
    }
    #endregion

    #region LoadFromIni()
    public void LoadFromIni(IniFile iniFile, IniFile.Section ini, GameExtensionPool pool, bool ignoreMasterServer)
    {
      this.Source = (SourceType) ini.GetInt("Type");
      this.Caption = ini.GetString("TabName");
      this.MasterServer = (ignoreMasterServer ? null : ini.GetString("MasterServer")) ?? "";
      this.InitialGameID = ini.GetInt("InitialGameID");
      this.FilterMod = ini.GetString("FilterMod");
      this.FilterIP = ini.GetString("FilterIP");
      this.BlockedIPs = ini.GetString("BlockedIPs");
      this.FilterMap = ini.GetString("FilterMap");
      this.MapsExcludeServer = ini.GetString("ExcludeMaps");
      this.TagsIncludeServer = ini.GetString("TagsInclude");
      this.TagsExcludeServer = ini.GetString("TagsExclude");
      this.NamesIncludeServer = ini.GetString("NamesInclude");
      this.NamesExcludeServer = ini.GetString("NamesExclude");
      this.VersionMatch = ini.GetString("VersionMatch");
      this.GetEmptyServers = ini.GetBool("GetEmptyServers", true);
      this.GetFullServers = ini.GetBool("GetFullServers", true);
      this.GetOfficialServers = ini.GetBool("GetOfficialServers", true);
      this.MasterServerQueryLimit = ini.GetInt("MasterServerQueryLimit", this.MasterServerQueryLimit);
      this.GridFilter = ini.GetString("GridFilter");
      this.MinPlayers = ini.GetInt("MinPlayers");
      this.MinPlayersInclBots = ini.GetBool("MinPlayersInclBots");
      this.MaxPing = ini.GetInt("MaxPing");
      this.TagsIncludeClient = ini.GetString("TagsIncludeClient");
      this.TagsExcludeClient = ini.GetString("TagsExcludeClient");

      this.CustomDetailColumns.Clear();
      foreach (var detail in (ini.GetString("CustomDetailColumns") ?? "").Split(','))
      {
        if (detail != "")
          CustomRuleColumns.Add(detail);
      }

      this.CustomRuleColumns.Clear();
      foreach (var rule in (ini.GetString("CustomRuleColumns") ?? "").Split(','))
      {
        if (rule != "")
          CustomRuleColumns.Add(rule);
      }

      this.HideColumns.Clear();
      foreach (var col in (ini.GetString("HideColumns") ?? "").Split(','))
      {
        if (col != "")
          HideColumns.Add(col);
      }

      var layout = ini.GetString("GridLayout");
      if (!string.IsNullOrEmpty(layout))
        this.ServerGridLayout = new MemoryStream(Convert.FromBase64String(layout));

      this.gameExtension = pool.Get((Game) this.InitialGameID);

      if (this.Source == SourceType.CustomList)
      {
        this.Servers = new List<ServerRow>();

        // new config format
        var sec = iniFile.GetSection(ini.Name + "_Servers");
        if (sec != null)
        {
          foreach (var key in sec.Keys)
          {
            var row = new ServerRow(Ip4Utils.ParseEndpoint(key), this.gameExtension);
            row.CachedName = sec.GetString(key);
            this.Servers.Add(row);
          }
        }
        else
        {
          // old config format
          var oldSetting = ini.GetString("Servers") ?? "";
          foreach (var server in oldSetting.Split('\n', ' '))
          {
            var s = server.Trim();
            if (s == "") continue;
            this.Servers.Add(new ServerRow(Ip4Utils.ParseEndpoint(s), this.gameExtension));
          }
        }
      }
    }
    #endregion

    #region WriteToIni()
    public void WriteToIni(StringBuilder ini, string sectionName, string tabName)
    {
      ini.AppendLine();
      ini.AppendLine($"[{sectionName}]");
      ini.Append("TabName=").AppendLine(tabName);
      ini.Append("Type=").Append((int) this.Source).AppendLine();
      if (this.Source == SourceType.MasterServer)
      {
        ini.Append("MasterServer=").AppendLine(this.MasterServer);
        ini.Append("InitialGameID=").Append(this.InitialGameID).AppendLine();
        ini.Append("FilterMod=").AppendLine(this.FilterMod);
        ini.Append("FilterIP=").AppendLine(this.FilterIP);
        ini.Append("BlockedIPs=").AppendLine(this.BlockedIPs);
        ini.Append("FilterMap=").AppendLine(this.FilterMap);
        ini.Append("ExcludeMaps=").AppendLine(this.MapsExcludeServer);
        ini.Append("TagsInclude=").AppendLine(this.TagsIncludeServer);
        ini.Append("TagsExclude=").AppendLine(this.TagsExcludeServer);
        ini.Append("NamesInclude=").AppendLine(this.NamesIncludeServer);
        ini.Append("NamesExclude=").AppendLine(this.NamesExcludeServer);
        ini.Append("VersionMatch=").AppendLine(this.VersionMatch);
        ini.Append("GetEmptyServers=").AppendLine(this.GetEmptyServers ? "1" : "0");
        ini.Append("GetFullServers=").AppendLine(this.GetFullServers ? "1" : "0");
        ini.Append("GetOfficialServers=").AppendLine(this.GetOfficialServers ? "1" : "0");
        ini.Append("MasterServerQueryLimit=").Append(this.MasterServerQueryLimit).AppendLine();
      }
      ini.Append("GridFilter=").AppendLine(this.GridFilter);
      ini.Append("MinPlayers=").AppendLine(this.MinPlayers.ToString());
      ini.Append("MinPlayersInclBots=").AppendLine(this.MinPlayersInclBots.ToString());
      ini.Append("MaxPing=").AppendLine(this.MaxPing.ToString());
      ini.Append("TagsIncludeClient=").AppendLine(this.TagsIncludeClient);
      ini.Append("TagsExcludeClient=").AppendLine(this.TagsExcludeClient);
      if (this.ServerGridLayout != null)
        ini.Append("GridLayout=").AppendLine(Base64GridLayout(this.ServerGridLayout));

      var sb = new StringBuilder();
      foreach (var detail in this.CustomDetailColumns)
        sb.Append(detail).Append(",");
      ini.Append("CustomDetailColumns=").AppendLine(sb.ToString().TrimEnd(','));

      sb = new StringBuilder();
      foreach (var rule in this.CustomRuleColumns)
        sb.Append(rule).Append(",");
      ini.Append("CustomRuleColumns=").AppendLine(sb.ToString().TrimEnd(','));

      sb = new StringBuilder();
      foreach (var col in this.HideColumns)
        sb.Append(col).Append(",");
      ini.Append("HideColumns=").AppendLine(sb.ToString().TrimEnd(','));

      if (this.Source == SourceType.CustomList)
      {
        ini.AppendLine();
        ini.AppendLine($"[{sectionName}_Servers]");
        foreach (var row in this.Servers)
          ini.AppendLine($"{row.EndPoint}={row.ServerInfo?.Name ?? row.CachedName}");
      }
    }
    #endregion

    #region Base64GridLayout()
    internal static string Base64GridLayout(MemoryStream stream)
    {
      var buf = new byte[stream.Length];
      stream.Seek(0, SeekOrigin.Begin);
      var len = stream.Read(buf, 0, buf.Length);
      return Convert.ToBase64String(buf, 0, len);
    }
    #endregion

    #region ToString()
    public override string ToString()
    {
      return this.Caption + ": " + (this.servers?.Count ?? 0);
    }
    #endregion
  }
}
