using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using MEFramework.GridViewContextMenu;
using MEFramework.GridViewContextMenu.Base;
using MEFramework.GridViewContextMenu.GridViewContextMenu.DXMenuItems;
using System;
using System.Windows.Forms;

namespace MEFramework.GridViewContextMenu.GridViewContextMenu.Creators
{
    public class ContextMenuItemCreatorGridViewInit : IGridViewContextMenuItemCreator
    {
        public DXMenuItem Create(GridView view)
        {
            if (view.Columns.Count <= 0)
                return null;

            DXMenuItemGridViewInit dXMenuItem = new DXMenuItemGridViewInit()
            {
                Caption = "초기화",
                View = view
            };

            return dXMenuItem;
        }
    }
}
