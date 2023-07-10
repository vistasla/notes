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
    class DeSerializableExample_1
    {
        public DeSerializableExample_1()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("SerializableForm.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            SerializableForm sf1 = (SerializableForm) formatter.Deserialize(stream);
            stream.Close();
            //Console.WriteLine(sf1.textBox.Text);
            //Console.WriteLine(sf1.textBox);
            /*Console.WriteLine(me.AccountId);
            Console.WriteLine("test:" + me.test);*/
            Console.WriteLine(sf1.ToString()); 
        }

    }
}
