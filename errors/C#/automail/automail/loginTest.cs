using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automail
{
   
    class loginTest
    {
        Boolean[] booleanArray = new Boolean[5];


        public loginTest(string strUrl)
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
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
          
            void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {
                intLoadTime++;
                Console.WriteLine(intLoadTime);
                
                if (intLoadTime == 1)
                {
                    HtmlDocument hd = webBrowser.Document;
                /*HtmlElement he = hd.GetElementById("u");
                HtmlElement he1 = hd.GetElementById("p");
                HtmlElement he2 = hd.GetElementById("login_button");

                string strUser = "3045277806";
                string strPassword = "123456pw";

                he.SetAttribute("value", strUser);
                he1.SetAttribute("value", strPassword);
                he2.InvokeMember("submit");
*/
                //https://jhjhbh.site/mail/?_task=mail&_mbox=INBOX
                    /* HtmlElement he2 = hd.GetElementById("qlogin_show");
                     Console.WriteLine(he2.GetAttribute("class"));*/
                    /* HtmlElement he2 = hd.GetElementById("switcher_plogin");

                     Console.WriteLine(he2.GetAttribute("href"));*/
                    //HtmlElement he2 = hd.GetElementById("login_div");
                    // Console.WriteLine(he2.GetAttribute("class"));
                    //Console.WriteLine(he2.OuterHtml);
                    //HtmlElement he2 = hd.GetElementById("login_frame");
                    //Console.WriteLine(he2.OuterHtml);
                    string strHtmlDocumentCookie;
                    //strHtmlDocumentCookie = hd.Cookie;
                    // Console.WriteLine(strHtmlDocumentCookie);
                    /*hd.Cookie = "roundcube_sessauth=H3G3HwpOcA2Gpxd7J1oGc1tuOc-1583921100";
                    hd.Cookie = "roundcube_sessid=5l43qpq3rku8a5j5snlaoenj7a";*/
                    hd.Cookie = "roundcube_sessauth=WcuoxTHFTNMlAh6k8Fu2qAOQ0F-1583931900";
                    hd.Cookie = "roundcube_sessid=e5hnmg9bedhcui2q38shen89pu";
                    strHtmlDocumentCookie = hd.Cookie;
                    Console.WriteLine(strHtmlDocumentCookie);
                    webBrowser.Navigate(strUrl);
                    //Console.WriteLine("sucucess open:" + "");

                }
                
                
                
            }
        }
    }
}
