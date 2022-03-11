using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFramework.GridViewContextMenu.Base
{
    public interface IContextMenuItem
    {
        void Execute();
    }
}
