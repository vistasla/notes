using System;
using System.Windows.Forms;

namespace automail
{

    class loginTest_Qzone
    {
        Boolean[] booleanArray = new Boolean[5];


        public loginTest_Qzone(string strUrl)
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
            webBrowser.Navigating += WebBrowser_Navigating;
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
            void WebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
            {

                HtmlDocument hd = webBrowser.Document;



                string strHtmlDocumentCookie;
                // strHtmlDocumentCookie = hd.Cookie;
                hd.Cookie = null;             
                hd.Cookie = "p_skey=I6WYGqM3EIDXcW2WjLFapOqUGs8XNpt5i*b2G1lObck_";
                hd.Cookie = "p_uin=o3045277806";
                hd.Cookie = "skey=@4v0msKIw3";
                hd.Cookie = "uin=o3045277806";
                strHtmlDocumentCookie = hd.Cookie;
                Console.WriteLine(strHtmlDocumentCookie);
                //webBrowser.Navigate(strUrl);
            }
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
                    //https://user.qzone.qq.com/3045277806?_t_=0.4423501358252163
                    /* HtmlElement he2 = hd.GetElementById("qlogin_show");
                     Console.WriteLine(he2.GetAttribute("class"));*/
                    /* HtmlElement he2 = hd.GetElementById("switcher_plogin");

                     Console.WriteLine(he2.GetAttribute("href"));*/
                    //HtmlElement he2 = hd.GetElementById("login_div");
                    // Console.WriteLine(he2.GetAttribute("class"));
                    //Console.WriteLine(he2.OuterHtml);
                    //HtmlElement he2 = hd.GetElementById("login_frame");
                    //Console.WriteLine(he2.OuterHtml);
                    //string strHtmlDocumentCookie;
                    //strHtmlDocumentCookie = hd.Cookie;
                    //Console.WriteLine(strHtmlDocumentCookie);
                    /*hd.Cookie = "p_skey=I6WYGqM3EIDXcW2WjLFapOqUGs8XNpt5i*b2G1lObck_";
                    hd.Cookie = "p_uin=o3045277806";
                    hd.Cookie = "skey=@4v0msKIw3";
                    hd.Cookie = "uin=o3045277806";
                    strHtmlDocumentCookie = hd.Cookie;
                    Console.WriteLine(strHtmlDocumentCookie);*/
                    // webBrowser.Navigate(strUrl);
                    //Console.WriteLine("sucucess open:" + "");

                }



            }
        }

        /*private void WebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            throw new NotImplementedException();
        }*/
    }
}
