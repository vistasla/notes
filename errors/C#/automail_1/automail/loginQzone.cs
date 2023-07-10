using System;
using System.Windows.Forms;

namespace automail
{

    class loginQzone
    {
        Boolean[] booleanArray = new Boolean[5];


        public loginQzone(string strUrl)
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
                    
                    //int intVersion = webBrowser.Version.Major;//11
                    //int intVersion = webBrowser.Version.Build;//9600
                    //int intVersion = webBrowser.Version.MajorRevision;//0
                    //int intVersion = webBrowser.Version.Minor;//0
                    // int intVersion = webBrowser.Version.MinorRevision;//19597
                    //int intVersion = webBrowser.Version.Revision;//19597
                    //Console.WriteLine(intVersion);


                    //https://i.qq.com/

                }
                if (intLoadTime == 1)
                {
                    HtmlDocument hd = webBrowser.Document;
                    /*HtmlElement he2 = hd.GetElementById("login_frame");
                    
                    Console.WriteLine(he2.OuterHtml);*/
                    //Console.WriteLine(he2.InnerHtml);
                    HtmlElement he = hd.GetElementById("u");
                    HtmlElement he1 = hd.GetElementById("p");
                    HtmlElement he2 = hd.GetElementById("login_button");
                    HtmlElement he3 = hd.GetElementById("switcher_plogin");
                    he3.InvokeMember("click");
                    /*string strUser = "3045277806";
                    string strPassword = "123456pw";

                    he.SetAttribute("value", strUser);
                    he1.SetAttribute("value", strPassword);
                    Timer timer = new Timer();

                    timer.Interval = 1000 * 3;
                    timer.Tick += Timer_Tick;
                    void Timer_Tick(object sender1, EventArgs e1)
                    {
                        he2.InvokeMember("click");
                        throw new NotImplementedException();
                    }
                    timer.Start();*/
                   // he2.InvokeMember("click");


                    /* HtmlElement he2 = hd.GetElementById("qlogin_show");
                     Console.WriteLine(he2.GetAttribute("class"));*/
                    /* HtmlElement he2 = hd.GetElementById("switcher_plogin");

                     Console.WriteLine(he2.GetAttribute("href"));*/
                    //HtmlElement he2 = hd.GetElementById("login_div");
                    // Console.WriteLine(he2.GetAttribute("class"));
                    //Console.WriteLine(he2.OuterHtml);



                }

                if (intLoadTime == 3)
                {
                   /* HtmlDocument hd = webBrowser.Document;
                   
                    *//*HtmlElement he = hd.GetElementById("tb_friend_li");
                    he.InvokeMember("mouseover");*//*
                    HtmlElement he = hd.GetElementById("friend_search_input");
                    string strUser = "3045277806";                    
                    he.SetAttribute("value", strUser);*/
                   









                }
                if (intLoadTime == 4)
                {
                    /*HtmlDocument hd = webBrowser.Document;

                    HtmlElement he1 = hd.GetElementById("search_friend_result");
                    if (!(he1.InnerHtml == null))
                    {


                    }
                    else
                    {



                    }*/









                }
                /*if (intLoadTime == 7)
                {
                    HtmlDocument hd = webBrowser.Document;
                    string strUrl1 = "https://user.qzone.qq.com/3045277806?_t_=0.4423501358252163";
                    webBrowser.Navigate(strUrl1);
                }*/
            }
        }
    }
}
