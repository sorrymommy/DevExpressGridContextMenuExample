using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;

namespace MEFramework.GridViewContextMenu.Base
{
    public interface IGridViewContextMenuItemCreator
    {
        DXMenuItem Create(GridView view);
    }
}
