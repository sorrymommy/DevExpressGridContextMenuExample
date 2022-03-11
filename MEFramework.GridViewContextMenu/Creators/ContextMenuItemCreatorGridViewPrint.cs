using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using MEFramework.GridViewContextMenu;
using MEFramework.GridViewContextMenu.Base;
using MEFramework.GridViewContextMenu.GridViewContextMenu.DXMenuItems;

namespace MEFramework.GridViewContextMenu.GridViewContextMenu.Creators
{
    public class ContextMenuItemCreatorGridViewPrint : IGridViewContextMenuItemCreator
    {
        const string CST_MenuCaption_Print        = "출력";
        public DXMenuItem Create(GridView view)
        {
            return new DXMenuItemGridViewPrint() { Caption = CST_MenuCaption_Print, View = view, GridViewPrint = new GridViewPrint.GridViewPrint() };
        }
    }
}
