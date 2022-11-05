using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace ServerBrowser
{
    public class PostScriptum : GameExtension
    {
        // Post Scriptum servers don't report their player count to steam, only visible through A2S_Rules and not responding to A2S_PLAYER query...
        public PostScriptum()
        {
            this.supportsPlayersQuery = false;
        }
        public override void CustomizeServerGridColumns(GridView view)
        {
            var colDescription = view.Columns["ServerInfo.Description"];
            var idx = colDescription.VisibleIndex;
            colDescription.Visible = false;
            AddColumn(view, "_gamemode", "Game Mode", "Game Mode", 40, idx).OptionsFilter.AutoFilterCondition = AutoFilterCondition.Default;
        }
        public override int? GetRealPlayerCount(ServerRow row)
        {
            int pl;
            if (int.TryParse(row.GetRule("PlayerCount_i"), out pl))
                return pl;

            return base.GetRealPlayerCount(row);
        }
        public override object GetServerCellValue(ServerRow row, string fieldName)
        {
            if (fieldName == "_gamemode")
            {
                return row.GetRule("GameMode_s");
            }
            
            return base.GetServerCellValue(row, fieldName);
        }
    }
}
