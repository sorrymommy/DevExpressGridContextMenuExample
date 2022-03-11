using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using MEFramework.GridViewPrint.Base;

namespace MEFramework.GridViewContextMenu.GridViewContextMenu.GridViewPrint
{
    public class GridViewPrint : IGridViewPrint
    {
        private CompositeLink compositeLink;
        private PrintingSystem ps;
        private PrintableComponentLink link;

        public GridViewPrint()
        {
            compositeLink = new CompositeLink();
            ps = new PrintingSystem();
            link = new PrintableComponentLink(ps);

            compositeLink.PrintingSystem = ps;
            compositeLink.Landscape = true;
            compositeLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            ps.PageSettings.Landscape = true;

        }

        private void Load(BaseView view)
        {
            link.Component = view.GridControl;
            compositeLink.Links.Clear();
            compositeLink.Links.Add(link);
            link.CreateDocument();
        }

        public void Print(BaseView view)
        {
            Load(view);

            ps.Print();
        }

        public void Preview(BaseView view)
        {
            Load(view);

            ps.PreviewRibbonFormEx.Show();
        }
    }
}
