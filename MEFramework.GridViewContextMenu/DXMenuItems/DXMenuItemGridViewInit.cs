using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MEFramework.GridViewContextMenu;
using MEFramework.GridViewContextMenu.Base;
using System;
using System.IO;
using System.Windows.Forms;

namespace MEFramework.GridViewContextMenu.GridViewContextMenu.DXMenuItems
{
    public class DXMenuItemGridViewInit : DXMenuItem, IContextMenuItem
    {
        public DXMenuItemGridViewInit()
        {
            this.Click += (s, e) => { Execute(); };
        }
        public void Execute()
        {
            string fileName = GetOriginalFileName();
            
            if (!File.Exists(fileName))
                return;

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                OptionsLayoutGrid layout = new OptionsLayoutGrid();

                layout.Columns.AddNewColumns    = true;
                layout.Columns.RemoveOldColumns = true;
                layout.Columns.StoreAllOptions  = true;

                (View as GridView).RestoreLayoutFromStream(fs, layout);
            }
        }
        public BaseView View{ get; set; }

        private const string CST_GRID_PATH = "{0}\\Grid";
        private const string CST_GRID_ORIGINAL_FILE_FULL_PATH = "{0}\\{1}_{2}_original.dat";
        private string GetGridPath()
        {
            string BasePath = Path.GetDirectoryName(Application.ExecutablePath);

            string GridPath = string.Format(CST_GRID_PATH, BasePath);

            if (!Directory.Exists(GridPath))
                Directory.CreateDirectory(GridPath);

            return GridPath;
        }

        private string GetOriginalFileName()
        {
            return string.Format(CST_GRID_ORIGINAL_FILE_FULL_PATH, GetGridPath(), this.View.GridControl.FindForm().Name, this.View.Name);

        }
    }
}
