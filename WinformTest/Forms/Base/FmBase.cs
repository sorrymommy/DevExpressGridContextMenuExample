using System;
using System.Windows.Forms;
using WinFormTest.Lib;

namespace WinFormTest.Forms.Base
{
    public partial class FmBase : Form
    {
        public FmBase()
        {
            InitializeComponent();
        }

        private void FmBase_Load(object sender, EventArgs e)
        {
            (new GridViewContextMenuLoader()).LoadGridViewContextMenuInAllGridInControl(this);
        }
    }
}
