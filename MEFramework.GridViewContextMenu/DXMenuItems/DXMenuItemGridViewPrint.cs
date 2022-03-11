using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Base;
using MEFramework.GridViewContextMenu;
using MEFramework.GridViewContextMenu.Base;
using MEFramework.GridViewPrint;
using MEFramework.GridViewPrint.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEFramework.GridViewContextMenu.GridViewContextMenu.DXMenuItems
{
    public class DXMenuItemGridViewPrint : DXMenuItem, IContextMenuItem
    {
        public IGridViewPrint GridViewPrint { get; set; }
        public override void Dispose()
        {
            this.Click -= (s, e) => { Execute(); };
        }
        public DXMenuItemGridViewPrint()
        {
            this.Click += (s, e) => { Execute(); };
        }
        public void Execute()
        {
            if (this.GridViewPrint != null)
                this.GridViewPrint.Preview(this.View);
        }
        public BaseView View { get; set; }
    }
}
