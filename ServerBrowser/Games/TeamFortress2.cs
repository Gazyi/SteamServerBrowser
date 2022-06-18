using QueryMaster;

namespace ServerBrowser
{
    public class TeamFortress2 : GameExtension
    {
        public TeamFortress2()
        {
            // some games include bot count also in players count. This hardcoded list can be extended through the INI
            this.BotsIncludedInPlayerCount = true;
            // some games include bots also in player list. This hardcoded list can be extended through the INI
            this.BotsIncludedInPlayerList = true;
        }

        public override void CustomizeServerFilter(IpFilter filter)
        {
            // Valve's matchmaking servers don't respond to A2S_PLAYER queries, can't be joined from outside a lobby 
            // and the Valve network throttles clients to 100 requests per minute across all their servers and there are thousands of them.
            // They can be identified by the tag "valve", which we use to filter them out on the server side.
            if (!filter.IsOfficialServer)
            {
                // skip over user's filter and append our own
                while (filter.Nor != null)
                    filter = filter.Nor;

                filter.Nor = new IpFilter();
                filter.Nor.Sv_Tags = "valve,hidden";
            }

            // Clearing out hibernated servers without map. Their map name returns "nothing".
            // skip over user's filter and append our own
            while (filter.Nor != null)
                filter = filter.Nor;

            filter.Nor = new IpFilter();
            filter.Nor.Map = "nothing";
        }

        public override bool SupportsPlayersQuery(ServerRow server)
        {
            // in case the matchmaking servers weren't filtered out on the server side, we also have a client-side check here
            if (server?.ServerInfo?.Extra.Keywords != null && server.ServerInfo.Extra.Keywords.Contains("valve"))
                return false;

            return true;
        }
    }
}