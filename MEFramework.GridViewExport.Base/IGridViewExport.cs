using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFramework.GridViewExport.Base
{
    public interface IGridViewExport
    {
        void Export(BaseView view, ExportOption exportOption, string fileName);
    }
}
