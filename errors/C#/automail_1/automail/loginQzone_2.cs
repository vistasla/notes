using System;
using System.Windows.Forms;

namespace automail
{

    class loginQzone_2
    {
        Boolean[] booleanArray = new Boolean[5];


        public loginQzone_2(string strUrl)
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

                /* if (intLoadTime == 1)
                 {
                     HtmlDocument hd = webBrowser.Document;
                     HtmlWindowCollection hwc = hd.Window.Frames;

                    // Console.WriteLine("1:"+hwc.Count);
                     //https://i.qq.com/
                 }*/
                /*if (intLoadTime == 1)
                {
                    HtmlDocument hd = webBrowser.Document;
                    //HtmlWindowCollection hwc = hd.Window.WindowFrameElement;
                    HtmlElement he= hd.Window.WindowFrameElement;
                   
                    string strDocument = he.OuterHtml;
                    //string strDocument = hw.WindowFrameElement.InnerHtml;
                    //string strDocument = hw.WindowFrameElement.InnerText;

                 
                    Console.WriteLine(strDocument);
                }*/
                /* if (intLoadTime == 1)
                 {
                     HtmlDocument hd = webBrowser.Document;
                     //HtmlWindowCollection hwc = hd.Window.Frames;
                     //HtmlWindow hw = hwc[0];

                     //string strDocument = hw.WindowFrameElement.OuterHtml;
                     //string strDocument = hw.WindowFrameElement.InnerHtml;
                     //string strDocument = hw.WindowFrameElement.InnerHtml;
                     //string strDocument = hw.WindowFrameElement.InnerText;
                     string strDocument = webBrowser.DocumentText;
                     //Console.WriteLine("2:"+hwc.Count);
                     Console.WriteLine(strDocument);
                 }*/
                /*if (intLoadTime == 1)
                {
                    HtmlDocument hd = webBrowser.Document;
                    HtmlWindow hw = hd.Window;
                    //hw.Alert("hello world");
                    hw.Prompt("test", "hello world");
                    Console.WriteLine("test");
                }*/
                if (intLoadTime == 1)
                {
                    /*HtmlDocument hd = webBrowser.Document;
                    HtmlElement he = hd.GetElementById("u");
                    HtmlElement he1 = hd.GetElementById("p");
                    HtmlElement he2 = hd.GetElementById("login_button"); 
                    
                    string strUser = "3045277806";
                    string strPassword = "123456pw";

                    he.SetAttribute("value", strUser);
                    he1.SetAttribute("value", strPassword);
                    he2.InvokeMember("submit");*/
                    // he2.InvokeMember("click");
                    //HtmlDocument hd = webBrowser.Document;
                    
                    //HtmlElement he2 = hd.GetElementById("login_button");
                   // he2.InvokeMember("submit");
                   // he2.InvokeMember("click");
                    
                    HtmlDocument hd = webBrowser.Document;
                    HtmlElement he3 = hd.GetElementById("switcher_plogin");
                    //he3.Style = "display: block;";
                    //webBrowser.Refresh();
                    he3.InvokeMember("click");
                    HtmlElement he = hd.GetElementById("u");
                    HtmlElement he1 = hd.GetElementById("p");
                    HtmlElement he2 = hd.GetElementById("login_button");
                    // HtmlElement he4 = hd.GetElementById("loginform");
                    string strUser = "3045277806";
                    string strPassword = "123456pw";

                    he.SetAttribute("value", strUser);
                    he1.SetAttribute("value", strPassword);
                    he2.InvokeMember("click");
                   
                    //he2.InvokeMember("submmit");
                    //he2.RaiseEvent("click");
                    //he4.InvokeMember("click");
                   // he2.Parent.InvokeMember("click");
                   // Console.WriteLine(he2.Parent.GetAttribute("href"));
                    Console.WriteLine("login");
                }
                if (intLoadTime == 2)
                {
                    HtmlDocument hd = webBrowser.Document;
                    
                    Console.WriteLine("login sucecess");
                }
                
            }
        }
    }
}
