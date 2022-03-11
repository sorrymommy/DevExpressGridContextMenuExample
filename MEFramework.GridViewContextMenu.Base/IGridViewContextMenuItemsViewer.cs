using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using System.Collections.Generic;

namespace MEFramework.GridViewContextMenu.Base
{
    public interface IGridViewContextMenuItemsViewer
    {
        void ShowContextMenu(BaseView view, BaseHitInfo HitInfo);
        List<IGridViewContextMenuItemCreator> ContextMenuItemCreators { get; }
    }
}
