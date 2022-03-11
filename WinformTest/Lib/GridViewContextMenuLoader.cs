using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MEFramework.GridViewContextMenu;
using MEFramework.GridViewContextMenu.Base;
using MEFramework.GridViewContextMenu.GridViewContextMenu.Creators;
using System.Windows.Forms;

namespace WinFormTest.Lib
{
    public class GridViewContextMenuLoader
    {
        public void LoadGridViewContextMenuInAllGridInControl(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.HasChildren)
                    LoadGridViewContextMenuInAllGridInControl(c);

                if (c is GridControl)
                {
                    GridControl gc = c as GridControl;
                    foreach (GridView view in gc.Views)
                    {
                        IGridViewContextMenuItemsViewer contextMenuCreator = new GridViewContextMenuViewerColumnHeader(view);
                        contextMenuCreator.ContextMenuItemCreators.Add(new ContextMenuItemCreatorColumnVisible());
                        contextMenuCreator.ContextMenuItemCreators.Add(new ContextMenuItemCreatorGridViewInit());

                        contextMenuCreator = new GridViewContextMenuViewerDataRow(view);
                        contextMenuCreator.ContextMenuItemCreators.Add(new ContextMenuItemCreatorGridViewExport());
                        contextMenuCreator.ContextMenuItemCreators.Add(new ContextMenuItemCreatorGridViewPrint());
                    }
                }
            }
        }
    }
}
