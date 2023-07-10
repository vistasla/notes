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
    class SerializableExample_1
    {


        public SerializableExample_1()
        {
            
            SerializableForm sf = new SerializableForm();
            //sf.button.PerformClick();
           
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("SerializableForm.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, sf);
            stream.Close();



        }




    }
}
