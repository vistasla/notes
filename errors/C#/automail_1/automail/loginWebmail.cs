using System;
using System.Windows.Forms;
namespace automail
{
    class loginWebmail
    {
        Boolean[] booleanArray = new Boolean[5];
       
       
        public loginWebmail(string strUrl)
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
                    he.SetAttribute("value",strUser);
                    he1.SetAttribute("value", strPassword);
                    he2.InvokeMember("submit");
                   
                    Console.WriteLine("login:" +"" );

                //https://jhjhbh.site/mail/

                }
                if (intLoadTime == 3)
                {
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("rcmbtn101");
                    webBrowser.Navigate(he.GetAttribute("href"));
                    //HtmlElement he = hd.GetElementById("rcmbtn104");
                    // HtmlElement he = hd.GetElementById("taskmenu");
                    // HtmlElement he1 = hd.GetElementsByTagName("span")[1];
                    //Console.WriteLine(he.GetAttribute("href"));
                    // he.InvokeMember("click");
                    // HtmlElement he1 = he.FirstChild;
                    // HtmlElement he1 = he.GetElementsByTagName("span")[0];
                    //he.InvokeMember("click");

                    //he1.InvokeMember("click");
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
                    he1.SetAttribute("value", strCompose_to);
                    //he1.
                    he1.InvokeMember("blur");
                    he2.SetAttribute("value", strSubject);
                    he3.InnerText=strContent;
                    //he3.InnerHtml = strContent;
                   // he4.InvokeMember("click");
                    he4.InvokeMember("submmit");
                    Console.WriteLine("sucucess send:" + "");

                }
                if (intLoadTime == 5)
                {
                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("rcmloginuser");
                   
                   
                    //he.InvokeMember("submit");

                   

                    Console.WriteLine("sucucess send1:" + "");

                }
                if (intLoadTime == 7)
                {
                    intLoadTime = 3;

                    HtmlDocument hd = webBrowser.Document;

                    HtmlElement he = hd.GetElementById("rcmbtn100");
                   
                    he.InvokeMember("click");

                    

                    Console.WriteLine("sucucess init:" + "");

                }
            }
        }
    }
}
