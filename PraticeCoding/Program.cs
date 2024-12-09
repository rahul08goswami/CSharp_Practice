using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.CompilerServices;

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
            Address address = new Address();
            Address address1 = new Address();
            address.AddAddress();
            address1 = address[829122];
            address1 = address["54321"];
            Console.WriteLine(address1.PinCode);
            Console.ReadLine();


        }
    }

}
