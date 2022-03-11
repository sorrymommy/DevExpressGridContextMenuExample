using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using MEFramework.GridViewContextMenu;
using MEFramework.GridViewContextMenu.Base;
using MEFramework.GridViewContextMenu.GridViewContextMenu.DXMenuItems;
using MEFramework.GridViewExport;
using MEFramework.GridViewExport.Base;
using MEFramwork.GridViewContextMenu;

namespace MEFramework.GridViewContextMenu.GridViewContextMenu.Creators
{
    public class ContextMenuItemCreatorGridViewExport : IGridViewContextMenuItemCreator
    {
        const string CST_MenuCaption_Save         = "저장";

        const string CST_MenuCaption_CSV_value    = "CSV(화면표시값)";
        const string CST_MenuCaption_CSV_data     = "CSV(데이터)";
        const string CST_MenuCaption_XLS          = "Excel(2003이전버전)";
        const string CST_MenuCaption_XLS_value    = "Excel(화면표시값)";
        const string CST_MenuCaption_XLS_data     = "Excel(데이터)";
        public DXMenuItem Create(GridView view)
        {
            DXSubMenuItem dXSubMenuItem = new DXSubMenuItem()
            {
                Caption = CST_MenuCaption_Save
            };

            IGridViewExport gridViewExport = new GridViewExport.GridViewBasicExportHandler();

            dXSubMenuItem.Items.Add(new DXMenuItemGridViewExport() { Caption = CST_MenuCaption_XLS_data   , View = view, GridViewExporter = gridViewExport, ExportType = GridViewExportType.XlsxData  });
            dXSubMenuItem.Items.Add(new DXMenuItemGridViewExport() { Caption = CST_MenuCaption_XLS_value  , View = view, GridViewExporter = gridViewExport, ExportType = GridViewExportType.XlsxValue });
            dXSubMenuItem.Items.Add(new DXMenuItemGridViewExport() { Caption = CST_MenuCaption_XLS        , View = view, GridViewExporter = gridViewExport, ExportType = GridViewExportType.XlsData   });
            dXSubMenuItem.Items.Add(new DXMenuItemGridViewExport() { Caption = CST_MenuCaption_CSV_value  , View = view, GridViewExporter = gridViewExport, ExportType = GridViewExportType.CsvValue, BeginGroup = true });
            dXSubMenuItem.Items.Add(new DXMenuItemGridViewExport() { Caption = CST_MenuCaption_CSV_data   , View = view, GridViewExporter = gridViewExport, ExportType = GridViewExportType.CsvData   });

            return dXSubMenuItem;
        }
    }
}
