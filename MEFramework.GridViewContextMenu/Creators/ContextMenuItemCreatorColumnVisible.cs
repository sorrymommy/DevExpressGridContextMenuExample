using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Grid;
using MEFramework.GridViewContextMenu;
using MEFramework.GridViewContextMenu.Base;
using MEFramework.GridViewContextMenu.GridViewContextMenu.DXMenuItems;
using System;

namespace MEFramework.GridViewContextMenu.GridViewContextMenu.Creators
{
    public class ContextMenuItemCreatorColumnVisible : IGridViewContextMenuItemCreator
    {
        const string CST_MenuCaption_Column = "항목";

        public static string CST_MenuCaption_Column1 => CST_MenuCaption_Column;

        public DXMenuItem Create(GridView view)
        {
            if (view.Columns.Count <= 0)
                return null;

            DXSubMenuItem columnsItem = new DXSubMenuItem(CST_MenuCaption_Column);
            columnsItem.Image = GridMenuImages.Column.Images[3];

            foreach (GridColumn column in (view).Columns)
            {
                if (column.OptionsColumn.ShowInCustomizationForm)
                {
                    string caption = column.Caption;
                    if (caption.Equals(string.Empty))
                        caption = column.FieldName;

                    DXMenuItemColumnVisible checkItem = new DXMenuItemColumnVisible()
                    {
                        Caption = caption,
                        Checked = column.VisibleIndex >= 0,
                        Visible = true,
                        Column  = column
                    };
                    columnsItem.Items.Add(checkItem);
                }
            }

            return columnsItem;
        }
    }
}
