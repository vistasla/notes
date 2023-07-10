using System;
using System.Windows.Forms;

namespace automail
{
    public partial class startwindow : Form
    {
        public startwindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            string strUrl = textBox1.Text;
            //loginiredadmin li = new loginiredadmin(strUrl);
            //loginWebmail_1 lw1 = new loginWebmail_1(strUrl);
           // loginQzone lq = new loginQzone(strUrl);
            //loginQzone_4 lq4 = new loginQzone_4(strUrl);
            loginQzone_5 lq5 = new loginQzone_5(strUrl);
            //loginQzone_2 lq2 = new loginQzone_2(strUrl);
            // loginTest_Qzone ltq = new loginTest_Qzone(strUrl);
            //loginTest lt = new loginTest(strUrl);
            //loginTest_iRedMail ltm = new loginTest_iRedMail(strUrl);
            // loginQzone_2 lq2 = new loginQzone_2(strUrl);
            //SetWebBrowserCoreVersion sbc = new SetWebBrowserCoreVersion(strUrl);
        }
    }
}
