using System;
using System.Windows.Forms;

namespace automail
{
    internal class ClearClipboard
    {
        public ClearClipboard()
        {

            Clipboard.Clear();
            Console.WriteLine("ClearClipboard:");
        }
    }
}
