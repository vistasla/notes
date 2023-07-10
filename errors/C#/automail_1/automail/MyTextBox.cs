using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace automail
{
    [Serializable]
    public class MyTextBox  : System.Windows.Forms.TextBox , ISerializable
    //public class MyTextBox : System.Windows.Forms.TextBox:ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
