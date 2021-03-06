using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MEFramework.GridViewContextMenu;
using MEFramework.GridViewContextMenu.Base;
using System.Collections.Generic;

namespace MEFramework.GridViewContextMenu
{
    public class GridViewContextMenuViewerColumnHeader : GridViewContextMenuItemsVieweBase
    {
        public GridViewContextMenuViewerColumnHeader(GridView view) : base(view) { }
        protected override void InitHitTests(List<GridHitTest> gridHitTests)
        {
            base.InitHitTests(gridHitTests);

            gridHitTests.Add(GridHitTest.ColumnButton);
        }
    }
}
