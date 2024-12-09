using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.CompilerServices;
using ClassLibrary1;

namespace PraticeCoding
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Serialization and Deserialization
            //Serialization serialization = new Serialization();
            //serialization.Serialise();
            //Customer cust = (Customer)serialization.Deserialize();

            //IComparable and IComparer Interface
            //IComparableAndICompare comparableAndICompare = new IComparableAndICompare();
            //comparableAndICompare.DisplayCustomers(comparableAndICompare.GetCustomer());

            //Yield Keyword
            //Yield yield = new Yield();
            //yield.FillValues();
            //yield.Display(yield.list);

            //Indexer
            //Address address = new Address();
            //Address address1 = new Address();
            //address.AddAddress();
            //address1 = address[829122];
            //address1 = address["54321"];
            //Console.WriteLine(address1.PinCode);

            //Extension Methods
            Maths maths = new Maths();
            int result = maths.Add(1, 2, 3, 4, 5); //This Add Method is normal metgod present in Math class
            int result1 = maths.Subtract(10,5);// This Subtract is an extension method
            Console.WriteLine(result);
            Console.WriteLine(result1);
            //string.CallingExten()
            string m = maths.ToString();
            Console.WriteLine(m.CallingExten());

            Console.ReadLine();


        }
    }

}
