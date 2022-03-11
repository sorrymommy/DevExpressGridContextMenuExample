using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormTest.Forms.Base;

namespace WinFormTest.Forms
{
    public partial class Form1 : FmBase
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
                throw new Exception("ERROR");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ColumnA"));
            DataRow dr = dt.NewRow(); dt.Rows.Add(dr); dr["ColumnA"] = "ValueA-1";
            dr = dt.NewRow(); dt.Rows.Add(dr); dr["ColumnA"] = "ValueA-1";

            gridControl1.DataSource = dt;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
