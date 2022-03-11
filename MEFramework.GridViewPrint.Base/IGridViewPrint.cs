using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFramework.GridViewPrint.Base
{
    public interface IGridViewPrint
    {
        void Print(BaseView view);
        void Preview(BaseView view);
    }
}
