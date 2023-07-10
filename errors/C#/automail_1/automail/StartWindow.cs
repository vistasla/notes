using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace automail
{
    public partial class startwindow : Form
    {
        //[DllImport("user32.dll", EntryPoint = "PostMessageA", SetLastError = true, CharSet = CharSet.Auto)]
        [DllImport("user32.dll", EntryPoint = "PostMessageA", SetLastError = true)]
        public static extern int PostMessage(IntPtr hWnd, int Msg, Keys wParam, int lParam);

        public const int WM_CHAR = 256;

        // [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string strClass, string strWindow);

        // [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter,
                string strClass, string strWindow);

        public startwindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string strUrl = textBox1.Text;
            //loginiredadmin li = new loginiredadmin(strUrl);
            //loginWebmail_1 lw1 = new loginWebmail_1(strUrl);
            //loginQ zone_5 lq5 = new loginQzone_5(strUrl);
            //System.Diagnostics.Process.Start("test.exe");
            //ProcessThread processThread;
            //textBox1.Focus();
            //ClipboardTest clipboardTest = new ClipboardTest();
            // ShortCutKeyTest_Post sckt = new ShortCutKeyTest_Post();
            ClearClipboard clearClipboard = new ClearClipboard();
            button2.PerformClick();
            //this.FindForm().Hide();
            //Console.WriteLine("button1:");
            //ShortCutKeyTest_ScreenShoot shortCutKeyTest_ScreenShoot = new ShortCutKeyTest_ScreenShoot();
            // ClipboardTest clipboardTest = new ClipboardTest();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            ShortCutKeyTest_AllSelect shortCutKeyTest_AllSelect = new ShortCutKeyTest_AllSelect();
            this.FindForm().Show();
            button3.PerformClick();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Console.WriteLine("test1:");
            this.FindForm().Hide();
            // Console.WriteLine("test1:");
            ShortCutKeyTest_Copy shortCutKeyTest_Copy = new ShortCutKeyTest_Copy();
            this.FindForm().Show();
            button4.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClipboardTest clipboardTest = new ClipboardTest();
            /*this.FindForm().Hide();
            ShortCutKeyTest_Space shortCutKeyTest_Space = new ShortCutKeyTest_Space();
            this.FindForm().Show();
            button5.PerformClick();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            ShortCutKeyTest_Paste shortCutKeyTest_Paste = new ShortCutKeyTest_Paste();
            this.FindForm().Show();
        }
    }
}