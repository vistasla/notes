using System;
using System.Windows.Forms;

namespace automail
{

    class loginTest_iRedMail
    {
        Boolean[] booleanArray = new Boolean[5];


        public loginTest_iRedMail(string strUrl)
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
            webBrowser.Navigated += WebBrowser_Navigated;
            //webBrowser.Navigating += WebBrowser_Navigating;
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
            void WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
            {

                HtmlDocument hd = webBrowser.Document;



                string strHtmlDocumentCookie;

                hd.Cookie = "roundcube_sessauth=WcuoxTHFTNMlAh6k8Fu2qAOQ0F-1583931900";
                hd.Cookie = "roundcube_sessid=e5hnmg9bedhcui2q38shen89pu";
                strHtmlDocumentCookie = hd.Cookie;
                Console.WriteLine(strHtmlDocumentCookie);
                Console.WriteLine("test");
                Console.WriteLine(hd.Title);
                // webBrowser.Navigate(strUrl);


                // throw new NotImplementedException();
            }
            /*void WebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
            {

                HtmlDocument hd = webBrowser.Document;



                string strHtmlDocumentCookie;

                hd.Cookie = "roundcube_sessauth=WcuoxTHFTNMlAh6k8Fu2qAOQ0F-1583931900";
                hd.Cookie = "roundcube_sessid=e5hnmg9bedhcui2q38shen89pu";
                strHtmlDocumentCookie = hd.Cookie;
                Console.WriteLine(strHtmlDocumentCookie);
                Console.WriteLine("test");
                webBrowser.Navigate(strUrl);


            }*/
            void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {
                intLoadTime++;
                Console.WriteLine(intLoadTime);

                if (intLoadTime == 1)
                {
                   // webBrowser.Navigate(strUrl);
                    Console.WriteLine("sucecess login");

                    //https://jhjhbh.site/mail/?_task=mail&_mbox=INBOX


                }



            }
        }

       
    }
}
