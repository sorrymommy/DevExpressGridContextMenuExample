using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MEFramework.GridViewContextMenu.Base
{
    public class GridViewContextMenuItemsVieweBase : IDisposable, IGridViewContextMenuItemsViewer
    {
        protected GridView _GridView;
        private List<GridHitTest> GridHitTests;
        public GridViewContextMenuItemsVieweBase(GridView view)
        {
            _GridView = view;
            _GridView.MouseDown += Event_MouseDown;

            ContextMenuItemCreators = new List<IGridViewContextMenuItemCreator>();
            GridHitTests = new List<GridHitTest>();


            InitHitTests(GridHitTests);
        }

        protected virtual void InitHitTests(List<GridHitTest> gridHitTests)
        {
        }

        public void Dispose()
        {
            _GridView.MouseDown -= Event_MouseDown;
        }

        private void Event_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.Button != MouseButtons.Right)
                return;

            GridHitInfo gridHitInfo = view.CalcHitInfo(new Point(e.X, e.Y));

            if (GridHitTests.Where(x => x == gridHitInfo.HitTest).Count() > 0)
                ShowContextMenu(view, gridHitInfo);
        }
        public List<IGridViewContextMenuItemCreator> ContextMenuItemCreators { get; private set; }
        public void ShowContextMenu(BaseView view, BaseHitInfo HitInfo)
        {
            ViewMenu menu = new ViewMenu(view);

            foreach (IGridViewContextMenuItemCreator pmi in ContextMenuItemCreators)
                menu.Items.Add(pmi.Create(view as GridView));

            menu.Show(HitInfo.HitPoint);
        }
    }
}
