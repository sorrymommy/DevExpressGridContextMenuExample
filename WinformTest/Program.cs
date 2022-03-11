using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormTest.Forms;

namespace WindowsFormsApp12
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Event_ThreadException;

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.Run(new Form1());
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Screen sc = Screen.FromHandle(Application.OpenForms[0].Handle);

            Bitmap bitmap = new Bitmap(sc.Bounds.Height, sc.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Rectangle rect = sc.Bounds;
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);

            ShowingError(bitmap);
        }
        private static void Event_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Screen sc = Screen.FromHandle(Application.OpenForms[0].Handle);

            Bitmap bitmap = new Bitmap(sc.Bounds.Height, sc.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Rectangle rect = sc.Bounds;
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);

            ShowingError(bitmap);
        }

        private static void ShowingError(Bitmap bitmap)
        {
            Form form = new Form();
            form.Width = 500;
            form.Height = 500;
            PictureBox pictureBox = new PictureBox();
            pictureBox.Parent = form;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Show();
            pictureBox.Image = bitmap;
            form.ShowDialog();
        }

    }
}
