using System;
using System.Windows.Forms;
namespace automail
{
    class loginiredadmin
    {
        Boolean[] booleanArray = new Boolean[5];

        public loginiredadmin(string strUrl)
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
            int j = 100;
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
            
            void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {
                intLoadTime++;

                Console.WriteLine("intLoadTime" + intLoadTime);
                if (intLoadTime == 1)
                {
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("user");
                    HtmlElement he1 = hd.GetElementById("password");
                    HtmlElement he2 = hd.GetElementsByTagName("input")[2];
                    //Console.WriteLine(he2.GetAttribute("class"));
                    string strUser = "postmaster@jhjhbh.site";
                    string strPassword = "123456";
                    he.SetAttribute("value", strUser);
                    he1.SetAttribute("value", strPassword);
                    he2.InvokeMember("click");

                    Console.WriteLine("sucucess login:" + "");

                    //https://jhjhbh.site/iredadmin/login                 
                }
                if (intLoadTime == 2)
                {
                    HtmlDocument hd = webBrowser.Document;
                    HtmlElementCollection hec = hd.GetElementsByTagName("ul");

                    for (int i = 0; i < hec.Count; i++)
                    {
                        // Console.WriteLine(i+hec[i].GetAttribute("class"));
                        // Console.WriteLine(i +","+ hec[i].GetElementsByTagName("li").Count);
                    }

                    HtmlElement he = hec[3].GetElementsByTagName("li")[2].GetElementsByTagName("a")[0];
                    Console.WriteLine(he.GetAttribute("href"));
                    he.InvokeMember("click");

                    Console.WriteLine("sucucess open:" + "");

                }
                if (intLoadTime == 3)
                {
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementsByTagName("form")[0];
                    HtmlElementCollection hec = he.GetElementsByTagName("input");
                    HtmlElement he1 = hec[1];
                    HtmlElement he2 = hec[2];
                    HtmlElement he3 = hec[3];
                    HtmlElement he4 = hec[4];
                    HtmlElement he5 = hec[5];
                    HtmlElement he6 = hec[7];
                    j++;
                    string strUser = "test" + j;
                    string strPassword = "123456pw";
                    string strConfirmPassword = "123456pw";

                    he1.SetAttribute("value", strUser);
                    he2.SetAttribute("value", strPassword);
                    he3.SetAttribute("value", strConfirmPassword);
                    he5.SetAttribute("value", null);                    
                    he6.InvokeMember("click");

                    Console.WriteLine("sucucess create:" + "");

                }
                if (intLoadTime == 4)
                {
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElementCollection hec = hd.GetElementsByTagName("ul");
                    HtmlElement he = hec[3].GetElementsByTagName("li")[2].GetElementsByTagName("a")[0];                    
                    he.InvokeMember("click");

                    Console.WriteLine("sucucess reopen:" + "");

                }
                if (intLoadTime == 5)
                {
                    intLoadTime = 3;
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementsByTagName("form")[0];
                    HtmlElementCollection hec = he.GetElementsByTagName("input");
                    HtmlElement he1 = hec[1];
                    HtmlElement he2 = hec[2];
                    HtmlElement he3 = hec[3];
                    HtmlElement he4 = hec[4];
                    HtmlElement he5 = hec[5];
                    HtmlElement he6 = hec[7];
                    j++;

                    string strUser = "test" + j;
                    string strPassword = "123456pw";
                    string strConfirmPassword = "123456pw";

                    he1.SetAttribute("value", strUser);
                    he2.SetAttribute("value", strPassword);
                    he3.SetAttribute("value", strConfirmPassword);
                    he5.SetAttribute("value", null);
                    Console.WriteLine(he6.GetAttribute("value"));
                    he6.InvokeMember("click");

                    Console.WriteLine("sucucess recreate:" + "");

                }
            }
        }
    }
}
