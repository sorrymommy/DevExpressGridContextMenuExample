using DevExpress.XtraGrid.Views.Base;
using MEFramework.GridViewExport;
using MEFramework.GridViewExport.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFramework.GridViewContextMenu.GridViewContextMenu.GridViewExport
{
    public class GridViewBasicExportHandler : IGridViewExport
    {
        private void DoExport(BaseView view, ExportOption exportOption, string FileName)
        {
            switch (exportOption)
            {
                case ExportOption.CsvData:
                    view.ExportToCsv(FileName, new DevExpress.XtraPrinting.CsvExportOptions() { TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value });
                    break;
                case ExportOption.CsvValue:
                    view.ExportToCsv(FileName, new DevExpress.XtraPrinting.CsvExportOptions() { TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text });
                    break;
                case ExportOption.XlsData:
                    view.ExportToXls(FileName, new DevExpress.XtraPrinting.XlsExportOptions() { Suppress65536RowsWarning = true, Suppress256ColumnsWarning = true, TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value });
                    break;
                case ExportOption.XlsValue:
                    view.ExportToXls(FileName, new DevExpress.XtraPrinting.XlsExportOptions() { Suppress65536RowsWarning = true, Suppress256ColumnsWarning = true, TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text });
                    break;
                case ExportOption.XlsxData:
                    view.ExportToXlsx(FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value });
                    break;
                case ExportOption.XlsxValue:
                    view.ExportToXlsx(FileName, new DevExpress.XtraPrinting.XlsxExportOptions() { TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text });
                    break;
            }

        }

        public void Export(BaseView view, ExportOption exportOption, string fileName)
        {
            if (string.Empty.Equals(fileName))
                return;

            DoExport(view, exportOption, fileName);
        }
    }
}
