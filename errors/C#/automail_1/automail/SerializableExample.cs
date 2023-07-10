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
    
 public   class SerializableExample
    {
      public  SerializableExample() {
            AuthUserEntry user = new AuthUserEntry();
            user.AccountId = 9912053;
            user.AccountName = "test";
            user.test = "test1";
            //IFormatProvider formatProvider = new IFormatProvider();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("UserInfo.bin",FileMode.Create,FileAccess.Write,FileShare.None);
            formatter.Serialize(stream,user);
            stream.Close();



        }
        


    }
}
