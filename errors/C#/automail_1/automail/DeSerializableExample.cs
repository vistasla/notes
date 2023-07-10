using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace automail
{
    class DeSerializableExample

    {
        public DeSerializableExample() { 
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("UserInfo.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
        AuthUserEntry me = (AuthUserEntry) formatter.Deserialize(stream);
        stream.Close();
            Console.WriteLine(me.AccountName);
            Console.WriteLine(me.AccountId);
            Console.WriteLine("test:"+me.test);

        }
    }
}
