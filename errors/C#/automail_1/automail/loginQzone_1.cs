using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automail
{
   
    class loginQzone_1
    {
        Boolean[] booleanArray = new Boolean[5];


        public loginQzone_1(string strUrl)
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
                    /*HtmlDocument hd = webBrowser.Document;
                    *//*HtmlElement he = hd.GetElementById("u");
                    HtmlElement he1 = hd.GetElementById("p");
                    HtmlElement he2 = hd.GetElementById("login_button");*//*
                    HtmlElement he3 = hd.GetElementById("switcher_plogin");
                    string strUser = "3045277806";
                    string strPassword = "123456pw";

                    *//* he.SetAttribute("value", strUser);
                     he1.SetAttribute("value", strPassword);
                     he2.InvokeMember("submit");*//*
                    he3.InvokeMember("click");
                    Console.WriteLine("login:" + "");*/

                    //https://i.qq.com/

                }
                if (intLoadTime == 2)
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

                   /* HtmlElement he2 = hd.GetElementById("qlogin_show");
                    Console.WriteLine(he2.GetAttribute("class"));*/
                   /* HtmlElement he2 = hd.GetElementById("switcher_plogin");

                    Console.WriteLine(he2.GetAttribute("href"));*/
                    //HtmlElement he2 = hd.GetElementById("login_div");
                   // Console.WriteLine(he2.GetAttribute("class"));
                    //Console.WriteLine(he2.OuterHtml);
                    HtmlElement he2 = hd.GetElementById("login_frame");
                    //Console.WriteLine(he2.OuterHtml);
                    string strHtmlDocumentCookie;
                    strHtmlDocumentCookie = hd.Cookie;
                    Console.WriteLine(strHtmlDocumentCookie);
                    //hd.Cookie = "test=value,test1=value1";
                    hd.Cookie = "test=value";
                    hd.Cookie = "test1=value1";
                    strHtmlDocumentCookie = hd.Cookie;
                    Console.WriteLine(strHtmlDocumentCookie);
                    //Console.WriteLine("sucucess open:" + "");

                }
                if (intLoadTime == 4)
                {
                    /*HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("compose_to");
                    HtmlElement he1 = he.GetElementsByTagName("input")[0];
                    HtmlElement he2 = hd.GetElementById("compose-subject");
                    HtmlElement he3 = hd.GetElementById("composebody");
                    HtmlElement he4 = hd.GetElementById("rcmbtn111");
                    string strCompose_to = "vistasla@163.com";
                    //string strSubject = "hello world";
                    string strSubject = "test";
                    string strContent = "hello world";
                    he1.SetAttribute("value", strCompose_to);
                   
                    he1.InvokeMember("blur");
                    he2.SetAttribute("value", strSubject);
                    he3.InnerText = strContent;
                   
                    he4.InvokeMember("submmit");*/
                    //Console.WriteLine("sucucess send:" + "");

                }
                
                
            }
        }
    }
}
