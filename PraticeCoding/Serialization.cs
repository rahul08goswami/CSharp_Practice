using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
   
    internal class Serialization
    {
        

        public void Serialise() 
        {
            Customer obj = new Customer();
            obj.Name = "Rahul";
            obj.Address = "Kolkata";
            Stream stream = new FileStream(@"C:\Rahul\sample.txt", FileMode.Create);

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            stream.Close();
        }

        public object Deserialize()
        {
            //DeSerialise
            Stream open = new FileStream(@"C:\Rahul\sample.txt", FileMode.Open);
            IFormatter deformatter = new BinaryFormatter();
            return deformatter.Deserialize(open); 
        }  

           
        
    }
}
