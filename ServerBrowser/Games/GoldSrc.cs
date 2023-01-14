using QueryMaster;

namespace ServerBrowser
{
    public class GoldSourceGame : GameExtension
    {
        public override void CustomizeServerFilter(IpFilter filter)
        {
            // In Steam API, regular GoldSource servers don't return "specport" value, unlike Source servers.
            // HLTV servers are returned as separate server with "gameport" set to 0 and "specport" set to HLTV port.
            // We can use IsProxy to filter them out.

            // skip over user's filter and append our own
            while (filter.Nor != null)
                filter = filter.Nor;

            filter.Nor = new IpFilter();
            filter.Nor.IsProxy = true;
        }
    }
}