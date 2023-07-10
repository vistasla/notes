using System;
using System.Windows.Forms;

namespace automail
{

    class loginQzone_5
    {
        Boolean[] booleanArray = new Boolean[5];


        public loginQzone_5(string strUrl)
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

                if (intLoadTime == 5)
                {
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("friend_search_input");
                    HtmlElement he1 = he.NextSibling;
                    HtmlElement he2 = hd.GetElementById("friends-drop-down");
                    
                    string strContent = "3045277806";
                    //he.Focus();
                    Timer timer = new Timer();
                    timer.Interval = 1000 * 5;
                    timer.Tick += Timer_Tick;
                    timer.Start();
                    void Timer_Tick(object sender1, EventArgs e1)
                    {
                        timer.Stop();
                        he2.Style = "display: block;";
                        he.Focus();
                        SendKeys.SendWait(strContent);
                        //SendKeys.SendWait("Keys.Enter");
                        SendKeys.SendWait("{ ENTER}");
                        // he1.InvokeMember("click");
                        // Console.WriteLine(intLoadTime);3045277806

                        //throw new NotImplementedException();
                    }
                    
                    

                }

            }
        }
    }
}
