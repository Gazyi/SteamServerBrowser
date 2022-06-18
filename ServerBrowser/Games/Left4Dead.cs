using QueryMaster;

namespace ServerBrowser
{
    public class Left4Dead : GameExtension
    {
        public override void CustomizeServerFilter(IpFilter filter)
        {
            // Filtering out matchmaking servers.
            // They can be identified by server name that look like "Valve Left4Dead <2> <Region> (srcds1073-syd1.171.92)". We use that to filter them out on the server side.
            if (!filter.IsOfficialServer)
            {
                // skip over user's filter and append our own
                while (filter.Nor != null)
                    filter = filter.Nor;

                filter.Nor = new IpFilter();
                // "name_match" can use * as a wildcard
                filter.Nor.HostnameMatch = "Valve Left4Dead * (srcds*)";
            }
        }
    }
}
