using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using MEFramework.GridViewContextMenu;
using MEFramework.GridViewContextMenu.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFramework.GridViewContextMenu.GridViewContextMenu.DXMenuItems
{
    public class DXMenuItemColumnVisible : DXMenuCheckItem, IContextMenuItem
    {
        public DXMenuItemColumnVisible()
        {
            this.Click += (s, e) => { Execute(); };
        }
        public void Execute()
        {
            this.Column.VisibleIndex = this.Column.VisibleIndex >= 0 ? -1 : this.Column.View.VisibleColumns.Count;
        }

        public GridColumn Column { get; set; }
    }
}
