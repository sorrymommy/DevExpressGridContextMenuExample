using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Base;
using MEFramework.GridViewContextMenu.Base;
using MEFramework.GridViewExport.Base;
using MEFramwork.GridViewContextMenu;
using System;
using System.IO;

namespace MEFramework.GridViewContextMenu.GridViewContextMenu.DXMenuItems
{
    public class DXMenuItemGridViewExport: DXMenuItem, IContextMenuItem
    {
        public IGridViewExport GridViewExporter { get; set; }
        public DXMenuItemGridViewExport()
        {
            this.Click += (s, e) => { Execute(); };
        }
        private ExportOption GetExportOption()
        {
            switch (this.ExportType)
            {
                case GridViewExportType.CsvValue:
                    return ExportOption.CsvValue;
                case GridViewExportType.CsvData:
                    return ExportOption.CsvData;
                case GridViewExportType.XlsValue:
                    return ExportOption.XlsValue;
                case GridViewExportType.XlsData:
                    return ExportOption.XlsData;
                case GridViewExportType.XlsxValue:
                    return ExportOption.XlsxValue;
                case GridViewExportType.XlsxData:
                    return ExportOption.XlsxData;
                default:
                    return ExportOption.XlsxData;
            }
        }
        private string GetExtension()
        {
            switch (this.ExportType)
            {
                case GridViewExportType.CsvValue:
                case GridViewExportType.CsvData:
                    return "csv";
                case GridViewExportType.XlsValue:
                case GridViewExportType.XlsData:
                    return "xls";
                case GridViewExportType.XlsxValue:
                case GridViewExportType.XlsxData:
                    return "xlsx";
                default:
                    return "xlsx";

            }
        }
        private string GetFileName()
        {
            return $"Export_{DateTime.Today.ToString("yyyyMMdd")}.{GetExtension()}";
        }
        public void Execute()
        {
            if (this.GridViewExporter != null) 
            {
                string fileName = GetFileName();
                this.GridViewExporter.Export(this.View, GetExportOption(), fileName);
                
                if (!File.Exists(fileName))
                    return;

                System.Diagnostics.ProcessStartInfo process = new System.Diagnostics.ProcessStartInfo(fileName);
                process.UseShellExecute = true;
                process.Verb = "open";

                System.Diagnostics.Process.Start(process);
            }
        }

        public GridViewExportType ExportType { get; set; }
        public BaseView View { get; set; }
    }
}
