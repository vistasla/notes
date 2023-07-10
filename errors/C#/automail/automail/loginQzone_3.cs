using System;
using System.Windows.Forms;
namespace automail
{

    class loginQzone_3
    {
        Boolean[] booleanArray = new Boolean[5];


        public loginQzone_3(string strUrl)
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
                }

                if (intLoadTime == 7)
                {
                    HtmlDocument hd = webBrowser.Document;

                    /*HtmlElement he = hd.GetElementById("tb_friend_li");
                    he.InvokeMember("mouseover");*/
                    //HtmlElement he = hd.GetElementById("friend_search_input");
                    HtmlElement he = hd.GetElementById("search_smart_panel_navigation_bar");
                    //HtmlElement he2 = he.Parent.FirstChild.FirstChild;
                    HtmlElement he2 = he.Parent.GetElementsByTagName("input")[0];
                    //HtmlElement he2 = he.Parent.FirstChild;
                    //Console.WriteLine(he2.GetAttribute("class"));
                    //Console.WriteLine(he2.InnerHtml);
                    Console.WriteLine(he2.OuterHtml);
                    string strUser = "3045277806";
                    //he.SetAttribute("value", strUser);
                    he2.Focus();
                    //he2.InnerText = "test";
                    SendKeys.Send("test1");
                    //he.InvokeMember("keydown");
                    //Console.WriteLine(he.GetAttribute("value"));
                    HtmlElement he1 = hd.GetElementById("search_friend_result");
                    if (!(he1.InnerHtml == null))
                    {
                       // Console.WriteLine("sucecess");

                    }
                    else
                    {

                       // Console.WriteLine("failed");

                    }
                    //Console.WriteLine(he1.OuterHtml);
                }
                if (intLoadTime == 8)
                {
                   
                }
                
            }
        }
    }
}
