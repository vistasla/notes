using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace automail
{

    class loginQzone_6
    {
        Boolean[] booleanArray = new Boolean[5];
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        //移动鼠标 
        public const int MOUSEEVENTF_MOVE = 0x0001;
        //模拟鼠标左键按下 
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //模拟鼠标左键抬起 
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        //模拟鼠标右键按下 
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //模拟鼠标右键抬起 
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //模拟鼠标中键按下 
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        //模拟鼠标中键抬起 
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        //标示是否采用绝对坐标 
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        #region 引用win32api方法

        /// <summary>
        /// 导入模拟键盘的方法
        /// </summary>
        /// <param name="bVk" >按键的虚拟键值</param>
        /// <param name= "bScan" >扫描码，一般不用设置，用0代替就行</param>
        /// <param name= "dwFlags" >选项标志：0：表示按下，2：表示松开</param>
        /// <param name= "dwExtraInfo">一般设置为0</param>
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        #endregion
        public loginQzone_6(string strUrl)
        {

            Form form = new Form();
            form.SetBounds((Screen.PrimaryScreen.Bounds.Width - 800) / 2, (Screen.PrimaryScreen.Bounds.Height - 450) / 2, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.SetBounds(0, 0, form.Width, form.Height);
            webBrowser.Dock = DockStyle.Fill;

            webBrowser.ScriptErrorsSuppressed = true;

            form.Controls.Add(webBrowser);

            form.Visible = true;

            webBrowser.Navigate(strUrl);
            int intLoadTime = 0;
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;

            void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {
                intLoadTime++;
                Console.WriteLine(intLoadTime);


                if (intLoadTime == 1)
                {
                    //https://xui.ptlogin2.qq.com/cgi-bin/xlogin?proxy_url=https%3A//qzs.qq.com/qzone/v6/portal/proxy.html&daid=5&&hide_title_bar=1&low_login=0&qlogin_auto_login=1&no_verifyimg=1&link_target=blank&appid=549000912&style=22&target=self&s_url=https%3A%2F%2Fqzs.qzone.qq.com%2Fqzone%2Fv5%2Floginsucc.html%3Fpara%3Dizone%26specifyurl%3Dhttp%253A%252F%252Fuser.qzone.qq.com%252F3045277806%253F_t_%253D0.4423501358252163%2526&pt_qr_app=%E6%89%8B%E6%9C%BAQQ%E7%A9%BA%E9%97%B4&pt_qr_link=http%3A//z.qzone.com/download.html&self_regurl=https%3A//qzs.qq.com/qzone/v6/reg/index.html&pt_qr_help_link=http%3A//z.qzone.com/download.html&pt_no_auth=1
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("u");
                    HtmlElement he1 = hd.GetElementById("p");
                    HtmlElement he2 = hd.GetElementById("login_button");

                    Timer timer = new Timer();
                    timer.Interval = 1000 * 3;
                    timer.Tick += Timer_Tick;
                    void Timer_Tick(object sender1, EventArgs e1)
                    {
                        HtmlElement he3 = hd.GetElementById("switcher_plogin");
                        he3.InvokeMember("click");
                        string strUser = "3045277806";
                        string strPassword = "123456pw";

                        he.SetAttribute("value", strUser);
                        he1.SetAttribute("value", strPassword);
                        he2.InvokeMember("click");
                        timer.Stop();

                        // throw new NotImplementedException();
                    }
                    timer.Start();

                }
                if (intLoadTime == 2)
                {

                    //HtmlDocument hd = webBrowser.Document;

                    //HtmlElement he = hd.GetElementById("tcaptcha_drag_thumb");
                    //HtmlElement he = hd.GetElementById("tcaptcha_drag_button");
                    //HtmlElement he = hd.GetElementById("slide");                   

                    /*Timer timer = new Timer();
                    timer.Interval = 1000 * 5;
                    timer.Tick += Timer_Tick;
                    timer.Start();
                    void Timer_Tick(object sender1, EventArgs e1)
                    {
                        timer.Stop();                        
                        SetCursorPos(870, 279);
                       // SetCursorPos(870, 179);
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                       // SetCursorPos(870, 379);
                        SetCursorPos(1045, 279);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                    }*/

                    //Console.WriteLine(he.Name);
                }
                if (intLoadTime == 5)
                {
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("friend_search_input");
                    HtmlElement he1 = he.NextSibling;
                    HtmlElement he2 = hd.GetElementById("friends-drop-down");
                    HtmlElement he3 = hd.GetElementById("search_friend_result");
                    string strContent = "3045277806";
                    //he.Focus();
                    Timer timer = new Timer();
                    timer.Interval = 1000 * 3;
                    timer.Tick += Timer_Tick;
                    timer.Start();
                    void Timer_Tick(object sender1, EventArgs e1)
                    {
                        timer.Stop();


                        he2.Style = "display: block;";
                        SetCursorPos(1028, 285);
                        he.Focus();
                        Timer timer2 = new Timer();
                        timer2.Interval = 1000 * 3;
                        timer2.Tick += Timer_Tick_2;
                        timer2.Start();
                        void Timer_Tick_2(object sender2, EventArgs e2)
                        {
                            timer2.Stop();
                            /*SetCursorPos(1028, 285);
                            he.Focus();*/
                            SendKeys.SendWait("3");
                            SetCursorPos(1195, 118);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            SetCursorPos(1169, 118);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            //SendKeys.SendWait(strContent);
                            // SendKeys.SendWait("~");
                            /*if (!(he3.InnerHtml == null))
                            {
                                Console.WriteLine("sucecess");
                                //  InsertUserInfo iui = new InsertUserInfo(strContent);

                            }
                            else
                            {

                                Console.WriteLine("failed");

                            }*/
                            //mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
                        }




                        /*SetCursorPos(774, 137);
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);*/

                        //SendKeys.SendWait(strContent);
                        /*SetCursorPos(1150, 115);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);*/

                        /*mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);*/
                        /*SetCursorPos(1028, 285);
                        he.Focus();
                        SendKeys.SendWait(strContent);
                        SendKeys.SendWait("{enter}");
                        SendKeys.SendWait("~");*/
                        /*SetCursorPos(774, 137);
                        SendKeys.SendWait("~");*/
                        /* SetCursorPos(1149, 116);
                         mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);*/
                        // mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        //SendKeys.SendWait("~");
                        //SendKeys.SendWait("{enter}");
                        // SendKeys.SendWait("~");
                        //mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        // SendKeys.SendWait("~");
                        //SendKeys.Send("~");
                        // SendKeys.SendWait("a");
                        //SendKeys.SendWait(strContent);
                        //SendKeys.SendWait("" + "");

                        //keybd_event(13, 0, 0, 0);
                        //keybd_event(13, 0, 0, 0);
                        //keybd_event(13, 0, 0, 0);
                        // keybd_event(32, 0, 0, 0);
                        //SendKeys.SendWait(strContent);
                        //keybd_event(13, 0, 0, 0);
                        //keybd_event(71, 0, 0, 0);
                        //keybd_event(13, 0, 0, 0);

                        //keybd_event(vk_return, 0, 0, 0);
                        //keybd_event(32, 0, 0, 0);
                        // SendKeys.SendWait("{ ENTER}");
                        // SendKeys.SendWait("{~}");
                        // keybd_event(13, 0, 0, 0);
                        /* keybd_event(13, 0, 0, 0);
                         keybd_event(13, 0, 0, 0);
                         keybd_event(13, 0, 0, 0);*/
                        //SendKeys.SendWait("{ ENTER}");
                        //SendKeys.SendWait("VK_RETURN");
                        //SendKeys.SendWait("0x0D");
                        // SendKeys.SendWait("13");
                        // keybd_event(13, 0, 0, 0);
                        //SendKeys.SendWait("");
                        //SendKeys.SendWait("");
                        //SendKeys.SendWait("");
                        // mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        // he1.InvokeMember("click");
                        // SendKeys.SendWait(strContent+ "{ ENTER}");
                        //SendKeys.SendWait(strContent + "~");
                        //SendKeys.SendWait("Keys.Enter");
                        //SendKeys.SendWait("{ ENTER}");
                        // he1.InvokeMember("click");
                        // Console.WriteLine(intLoadTime);3045277806

                        //throw new NotImplementedException();

                    }

                    Timer timer1 = new Timer();
                    timer1.Interval = 1000 * 9;
                    timer1.Tick += Timer_Tick_1;
                    timer1.Start();
                    void Timer_Tick_1(object sender1, EventArgs e1)
                    {
                        timer1.Stop();

                        /* HtmlDocument hd1 = webBrowser.Document;

                         HtmlElement he3 = hd.GetElementById("search_friend_result");
                         Console.WriteLine(he3.InnerHtml);*/
                        if (!(he3.InnerHtml == null))
                        {
                            Console.WriteLine("sucecess");
                            //  InsertUserInfo iui = new InsertUserInfo(strContent);

                        }
                        else
                        {

                            Console.WriteLine("failed");

                        }


                    }

                }
                if (intLoadTime == 6)
                {
                    /*HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("qz-search-box-input");
                   // HtmlElement he1 = he.NextSibling;
                   // HtmlElement he2 = hd.GetElementById("friends-drop-down");
                    HtmlElement he3 = hd.GetElementById("qz-search-box-result");
                    string strContent = "3045277806";
                   
                    Timer timer = new Timer();
                    timer.Interval = 1000 * 3;
                    timer.Tick += Timer_Tick;
                    timer.Start();
                    void Timer_Tick(object sender1, EventArgs e1)
                    {
                        timer.Stop();
                        he.Focus();
                        

                        SendKeys.SendWait(strContent);

                        SendKeys.SendWait("~");


                        *//*SetCursorPos(774, 137);
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);*//*
                    }
                    Timer timer1 = new Timer();
                    timer1.Interval = 1000 * 30;
                    timer1.Tick += Timer_Tick_1;
                    timer1.Start();
                    void Timer_Tick_1(object sender1, EventArgs e1)
                    {
                        timer1.Stop();

                        *//* HtmlDocument hd1 = webBrowser.Document;

                         HtmlElement he3 = hd.GetElementById("search_friend_result");
                         Console.WriteLine(he3.InnerHtml);*//*
                        if (!(he3.InnerHtml == null))
                        {
                            Console.WriteLine("sucecess");
                            //  InsertUserInfo iui = new InsertUserInfo(strContent);

                        }
                        else
                        {

                            Console.WriteLine("failed");

                        }
                    }*/
                }
            }
        }
    }
}
