using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace automail
{
    public partial class startwindow_1 : Form
    {
        //[DllImport("user32.dll", EntryPoint = "PostMessageA", SetLastError = true, CharSet = CharSet.Auto)]
        [DllImport("user32.dll", EntryPoint = "PostMessageA", SetLastError = true)]
        public static extern int PostMessage(IntPtr hWnd, int Msg, Keys wParam, int lParam);

        public const int WM_CHAR = 256;

        // [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string strClass, string strWindow);

        // [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [DllImport("user32.dll")]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter,
                string strClass, string strWindow);

        public startwindow_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //textBox1.Name = "textBox1";
            string strUrl = textBox1.Text;
            //loginiredadmin li = new loginiredadmin(strUrl);
            //loginWebmail_1 lw1 = new loginWebmail_1(strUrl);
            // loginQzone lq = new loginQzone(strUrl);
            //loginQzone_4 lq4 = new loginQzone_4(strUrl);
            // loginQzone_5 lq5 = new loginQzone_5(strUrl);
            //loginQzone_2 lq2 = new loginQzone_2(strUrl);
            // loginTest_Qzone ltq = new loginTest_Qzone(strUrl);
            //loginTest lt = new loginTest(strUrl);
            //loginTest_iRedMail ltm = new loginTest_iRedMail(strUrl);
            // loginQzone_2 lq2 = new loginQzone_2(strUrl);
            //SetWebBrowserCoreVersion sbc = new SetWebBrowserCoreVersion(strUrl);
            // textBox1.Focus();
            //PostMessage(textBox1.Handle, 256, Keys.A, 1);
            /*button1.Focus();
            PostMessage(button1.Handle, 256, Keys.A, 1);*/
            //UIntPtr intPtr = new UIntPtr(000B04B8) ;
            // IntPtr ptrDesktop = FindWindow("SysListView32", "FolderView");
            //IntPtr ptrText = FindWindow("Edit",null );
            //IntPtr ptrTest = FindWindow("WindowsForms10.Window.8.app.0.141b42a_r14_ad1", "Form1");
            //IntPtr ptrTest = FindWindow("WindowsForms10.Window.8.app.0.141b42a_r14_ad1", "Form1");
            //IntPtr ptrText = FindWindow("Edit", null);
            //IntPtr ptrText = FindWindow("Edit", null);
            //IntPtr ptrText =new IntPtr() ;
            // IntPtr ptrStartBtn = FindWindowEx(ptrDesktop, ptrText, "Edit", null);
            //IntPtr ptrStartBtn = FindWindowEx(ptrDesktop, , "Edit", null);
            // PostMessage(ptrStartBtn, 256, Keys.A, 1);
            //SendMessage sendMessage=new SendMessage();
            //PostMessage(ptrText, 256, Keys.A, 1);
            // Console.WriteLine(ptrText.ToInt64());
            // Console.WriteLine(ptrDesktop.ToInt64());
            // Console.WriteLine(ptrDesktop.ToString());
            // Console.WriteLine(ptrText.ToString());
            //Console.WriteLine(ptrTest.ToInt64());
            //Console.WriteLine(ptrTest.ToString());
            //MessageBox.Show(ptrDesktop.ToString());
            // MessageBox.Show(ptrTest.ToString());
            /*IntPtr ptrParent = new IntPtr();
            IntPtr ptrChildAfter = new IntPtr();
            IntPtr ptrText = FindWindowEx(ptrParent, ptrChildAfter, "Edit", null);
            Console.WriteLine(ptrText);
            Console.WriteLine(ptrText.ToString());*/
            /*IntPtr ptrMozillaWindow = FindWindow("MozillaWindowClass", null);
            Console.WriteLine(ptrMozillaWindow.ToString());*/
            /*IntPtr ptrText = FindWindow("Edit",null );
            Console.WriteLine(ptrText.ToString());*/
            //IntPtr ptrChrome = FindWindow("Chrome_RenderWidgetHostHWND", "Chrome Legacy Window");
            /*IntPtr ptrChrome = FindWindow("Chrome_RenderWidgetHostHWND", null);
            //IntPtr ptrChrome = FindWindow("Chrome_WidgetWin_1", "新标签页 - Google Chrome");
            Console.WriteLine(ptrChrome.ToString());*/
            /*IntPtr ptrDesktop = FindWindow("#32769 (桌面)", null);
            Console.WriteLine(ptrDesktop.ToString());*/
            /*IntPtr ptrParent = new IntPtr();
            IntPtr ptrChildAfter = new IntPtr();
            IntPtr ptrText = FindWindowEx(ptrParent, ptrChildAfter, "Notepad", "test - 记事本");
            Console.WriteLine(ptrText);
            Console.WriteLine(ptrText.ToString());*/
            /*IntPtr ptrText = FindWindow( "Notepad", "test - 记事本");
            //IntPtr ptrText = FindWindow("Edit", null);
            PostMessage(ptrText, 256, Keys.A, 1);
            
            Console.WriteLine(ptrText);*/
            // IntPtr ptrDesktop = FindWindow("#32769 (桌面)", null);
            //IntPtr ptrDesktop = FindWindow("SoPY_Status", null);
            //IntPtr ptrDesktop = FindWindow("TaskListThumbnailWnd", null);
            /* IntPtr ptrDesktop = FindWindow("tooltips_class32", null);
             Console.WriteLine(ptrDesktop);*/
            /*IntPtr ptrTextBox = FindWindow("WindowsForms10.EDIT.app.0.141b42a_r15_ad1", null);
            
            PostMessage(ptrTextBox, 256, Keys.A, 1);

            Console.WriteLine(ptrTextBox);*/
            /*IntPtr ptrButton = FindWindow("WindowsForms10.BUTTON.app.0.141b42a_r15_ad1", null);

           

            Console.WriteLine(ptrButton);*/
            /*IntPtr ptrForm = FindWindow("WindowsForms10.Window.8.app.0.141b42a_r15_ad1", null);
            IntPtr ptrChildAfter = new IntPtr();
            IntPtr ptrTextBox = FindWindowEx(ptrForm, ptrChildAfter, "WindowsForms10.EDIT.app.0.141b42a_r15_ad1", null);
            PostMessage(ptrTextBox, 256, Keys.A, 1);
            Console.WriteLine(ptrTextBox);*/
            /*IntPtr ptrText = FindWindow("Notepad", "test - 记事本");
            IntPtr ptrChildAfter = new IntPtr();
            IntPtr ptrTextBox = FindWindowEx(ptrText, ptrChildAfter, "Edit", null);
            //IntPtr ptrText = FindWindow("Edit", null);
            PostMessage(ptrTextBox, 256, Keys.A, 1);

            Console.WriteLine(ptrTextBox);*/
            /*IntPtr ptrForm = FindWindow("WindowsForms10.Window.8.app.0.141b42a_r15_ad1", null);
            IntPtr ptrChildAfter = new IntPtr();
            IntPtr ptrTextBox = FindWindowEx(ptrForm, ptrChildAfter, "WindowsForms10.EDIT.app.0.141b42a_r15_ad1", null);
            PostMessage(ptrTextBox, 256, Keys.A, 1);
            Console.WriteLine(ptrTextBox);*/
            /*IntPtr ptrText = FindWindow("Edit", null);
           
            PostMessage(ptrText, 256, Keys.A, 1);

            Console.WriteLine(ptrText);*/
            //IntPtr ptrMozillaWindow = FindWindow("MozillaWindowClass", null);
            /* IntPtr ptrMozillaWindow = FindWindow("MozillaWindowClass", "C#模拟键盘按键的三种方式实现 - jack_Meng - 博客园");
             Console.WriteLine(ptrMozillaWindow.ToString());*/
            //IntPtr ptrChrome = FindWindow("Chrome_WidgetWin_1", "新标签页 - Google Chrome");
            //IntPtr ptrChrome = FindWindow("Chrome_RenderWidgetHostHWND", "Chrome Legacy Window");
            /*IntPtr ptrChrome = FindWindow("Chrome_WidgetWin_0", null);
            //IntPtr ptrChrome = FindWindow("Chrome_RenderWidgetHostHWND", null);
            //IntPtr ptrChrome = FindWindow("Chrome_WidgetWin_1", "新标签页 - Google Chrome");
            Console.WriteLine(ptrChrome.ToString());*/
            //IntPtr ptrShell = FindWindow("Shell_TrayWnd", null);
            /*IntPtr ptrShell = FindWindow("TrayNotifyWnd", null);
            //IntPtr ptrChrome = FindWindow("Chrome_RenderWidgetHostHWND", null);
            //IntPtr ptrChrome = FindWindow("Chrome_WidgetWin_1", "新标签页 - Google Chrome");
            Console.WriteLine(ptrShell.ToString());*/
            // SerializableExample se = new SerializableExample();
            //SerializableExample_1 se = new SerializableExample_1();
            // SerializableForm sf1 = new SerializableForm();
            /*IntPtr ptrTest = FindWindow("WindowsForms10.Window.8.app.0.141b42a_r14_ad1", null);
            Console.WriteLine(ptrTest.ToString());*/
            //Reflection reflection = new Reflection();
            //System.Diagnostics.Process.Start("IExplore.exe");
           /* System.Diagnostics.Process.Start("IExplore.exe", "https://cn.bing.com/");
            System.Diagnostics.Process.Start("shutdown", "-s -t 0");*/
            AuthUserEntry aue = new AuthUserEntry();
            Reflection reflection = new Reflection(aue);
            //Type t = typeof(aue)
            //Type t = Type.GetType("aue");
            /*Type t = Type.GetType("AuthUserEntry");
            // Type t = typeof(AuthUserEntry);
            System.Reflection.MethodInfo[] Methods = t.GetMethods();
            // System.Reflection.MethodInfo[] Methods = t.;
            foreach (var method in Methods)
            {

                Console.WriteLine(method.Name);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DeSerializableExample des = new DeSerializableExample();
            // DeSerializableExample_1 des = new DeSerializableExample_1();

           // Type t = typeof(aue);
           /* Type t = typeof(AuthUserEntry);
            System.Reflection.MethodInfo[] Methods = t.GetMethods();
            // System.Reflection.MethodInfo[] Methods = t.;
            foreach (var method in Methods)
            {

                Console.WriteLine(method.Name);
            }*/

        }
    }
}
