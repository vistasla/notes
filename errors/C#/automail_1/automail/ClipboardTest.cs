using System;
using System.Windows.Forms;

namespace automail
{
    internal class ClipboardTest
    {
        public ClipboardTest()
        {
            /* string textData = "I want to put this string on the clipboard.";

             After this call, the data(string) is placed on the clipboard and tagged
              with a data format of "Text".
              Clipboard.SetData(DataFormats.Text, (Object)textData);
             string strClipboard = Clipboard.GetText();
             // Clipboard clipboard = new Clipboard();
              Console.WriteLine(strClipboard);*/
           // Clipboard.Clear();
            string strClipboard = Clipboard.GetText();
            Console.WriteLine(strClipboard);
        }
    }
}