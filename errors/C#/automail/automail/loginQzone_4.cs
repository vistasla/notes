using System;
using System.Windows.Forms;

namespace automail
{

    class loginQzone_4
    {
        Boolean[] booleanArray = new Boolean[5];


        public loginQzone_4(string strUrl)
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
                    //https://i.qq.com/
                    HtmlDocument hd = webBrowser.Document;
                    /*HtmlElement he2 = hd.GetElementById("login_frame");
                    
                    Console.WriteLine(he2.OuterHtml);*/
                    //Console.WriteLine(he2.InnerHtml);
                    HtmlElement he = hd.GetElementById("u");
                    HtmlElement he1 = hd.GetElementById("p");
                    HtmlElement he2 = hd.GetElementById("login_button");
                    HtmlElement he3 = hd.GetElementById("switcher_plogin");
                    he3.InvokeMember("click");
                    string strUser = "3045277806";
                    string strPassword = "123456pw";

                    he.SetAttribute("value", strUser);
                    he1.SetAttribute("value", strPassword);
                    he2.InvokeMember("click");
                   /* Timer timer = new Timer();

                    timer.Interval = 1000 * 3;
                    timer.Tick += Timer_Tick;
                    void Timer_Tick(object sender1, EventArgs e1)
                    {
                        he2.InvokeMember("click");
                        throw new NotImplementedException();
                    }
                    timer.Start();
                    */



                }

                if (intLoadTime == 3)
                {
                    

                }

            }
        }
    }
}
