using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace automail
{
    class loginWebmail_1
    {
        Boolean[] booleanArray = new Boolean[5];
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

        public loginWebmail_1(string strUrl)
        {
            booleanArray[0] = true;



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
            int intCount = 0;
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
            //webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser_DocumentCompleted);
            void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {
                intLoadTime++;
                Console.WriteLine(intLoadTime);
                if (intLoadTime == 1)
                {
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("rcmloginuser");
                    HtmlElement he1 = hd.GetElementById("rcmloginpwd");
                    HtmlElement he2 = hd.GetElementById("login-form");
                    string strUser = "pujing@jhjhbh.site";
                    string strPassword = "123456pw";
                    /*string strUser = "postmaster@jhjhbh.site";
                    string strPassword = "123456";*/
                    he.SetAttribute("value", strUser);
                    he1.SetAttribute("value", strPassword);
                    he2.InvokeMember("submit");

                    Console.WriteLine("login:" + "");

                    //https://jhjhbh.site/mail/

                }
                if (intLoadTime == 3) 
                {
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("rcmbtn101");
                    // HtmlElement he = hd.GetElementById("rcmbtn102");
                    // HtmlElement he = hd.GetElementById("rcmbtn103");
                    // HtmlElement he = hd.GetElementById("rcmbtn104");
                    Timer timer = new Timer();
                    timer.Interval = 1000 * 1 / 5;
                    timer.Tick += Timer_Tick;
                    void Timer_Tick(object sender1, EventArgs e1)
                    {
                        he.InvokeMember("click");
                        timer.Stop();
                    }
                    timer.Start();

                    //webBrowser.Navigate(he.GetAttribute("href"));

                    /*string strUrl1 = "./?_task=mail&_action=compose";
                    webBrowser.Navigate(strUrl1);*/
                    //he.Click;
                    Console.WriteLine("sucucess open:" + "");

                }
                if (intLoadTime == 4)
                {
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("compose_to");
                    HtmlElement he1 = he.GetElementsByTagName("input")[0];
                    HtmlElement he2 = hd.GetElementById("compose-subject");
                    HtmlElement he3 = hd.GetElementById("composebody");
                    HtmlElement he4 = hd.GetElementById("rcmbtn111");
                    string strCompose_to = "vistasla@163.com";
                    //string strSubject = "hello world";
                    string strSubject = "test";
                    string strContent = "hello world";
                    he1.Focus();
                    he1.InnerText = strCompose_to;
                    he1.RemoveFocus();
                    //he1.SetAttribute("value", strCompose_to);                   
                    //he1.InvokeMember("blur");
                    he2.SetAttribute("value", strSubject);
                    he3.Focus();
                    //SendKeys.Send(strContent);
                    Timer timer1 = new Timer();
                    timer1.Interval = 1000 *1 /50;
                    timer1.Tick += Timer_Tick_1;
                    timer1.Start();
                    void Timer_Tick_1(object sender1, EventArgs e1)
                    {
                        timer1.Stop();
                        //SendKeys.Send("strContent");
                        SendKeys.SendWait(strContent);
                        //he3.RemoveFocus();
                       
                        //he3.InnerText = strContent;
                        he4.InvokeMember("click");

                        //timer1.Stop();
                        intCount++;
                        Console.WriteLine("intCount:" + intCount);
                        
                        Console.WriteLine("sucucess send:" + "");
                        //throw new NotImplementedException();
                    }
                    //timer1.Stop();
                    //timer1.Start();
                    //SendKeys.Send("strContent");
                    //keybd_event(65, 0, 0, 0);

                    // SendKeys.SendWait("strContent");
                    // he3.InnerText=strContent;
                    // he3.RemoveFocus();


                    /* Timer timer = new Timer();
                     timer.Interval = 1000 * 1 / 5;
                     timer.Tick += Timer_Tick;
                     void Timer_Tick(object sender1, EventArgs e1)
                     {
                         he4.InvokeMember("click");
                         timer.Stop();
                         //throw new NotImplementedException();
                     }
                     timer.Start();*/
                    //he4.InvokeMember("click");
                    //he4.InvokeMember("submmit");

                    //Console.WriteLine("sucucess send:" + "");
                    //[DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)];
                    //InsertKeyMode.

                }
                if (intLoadTime == 7)
                {
                    intLoadTime = 3;

                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("rcmbtn101");
                    // he.InvokeMember("click");
                    Timer timer = new Timer();
                    timer.Interval = 1000 * 1 / 5;
                    timer.Tick += Timer_Tick;
                    void Timer_Tick(object sender1, EventArgs e1)
                    {
                        he.InvokeMember("click");
                        timer.Stop();
                    }
                    timer.Start();

                    Console.WriteLine("sucucess init1:" + "");

                }

            }
        }


    }
}
