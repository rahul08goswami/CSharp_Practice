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
using System.Reflection;
using System.Threading;

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
            //Maths maths = new Maths();
            //int result = maths.Add(1, 2, 3, 4, 5); //This Add Method is normal metgod present in Math class
            //int result1 = maths.Subtract(10,5);// This Subtract is an extension method
            //Console.WriteLine(result);
            //Console.WriteLine(result1);
            ////string.CallingExten()
            //string m = maths.ToString();
            //Console.WriteLine(m.CallingExten());

            // == VS .Eqauls()
            //string a = "Rahul";
            //string b = "Rahul";
            //Console.WriteLine(a == b); //True
            //Console.WriteLine(a.Equals(b)); //True
            //Customer customer = new Customer();
            //Customer customer1 = new Customer();
            //customer1.Name = "Rahul";
            //customer1.Address = "Kolkata";
            //customer1.Address = "Kolkata";
            //customer.Name = "Rahul";
            //Console.WriteLine(customer == customer1); // False
            //Console.WriteLine(customer.Equals(customer1)); //True as we have overriden .Equals Method in Customer

            //List<Customer> list = new List<Customer>();
            //list.Add(customer);
            //list.Add(customer1);
            //var v = typeof(Customer);
            //var v1 = customer.GetType();
            //Customer cust = list.Find((c) => c.Name == "Rahul" && c.Address == "Kolkata");

            //Reflection
            //var myAssembly = Assembly.LoadFile("C:\\Users\\rahul\\source\\repos\\CSharp_Practice\\ClassLibrary1\\bin\\Debug\\ClassLibrary1.dll");
            //var myType = myAssembly.GetType("ClassLibrary1.Maths");
            //dynamic obj = Activator.CreateInstance(myType);
            //Type parameterType = obj.GetType();

            //foreach (MemberInfo member in parameterType.GetMembers() )
            //{
            //    Console.WriteLine(member.Name);
            //}
            //int res = parameterType.InvokeMember("Add",BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Instance
            //    , null, obj,null);

            //Async And Await
            //AsyncAwait asyncAwait = new AsyncAwait();
            //asyncAwait.CallMethod();
            //Task.Run(new Action(asyncAwait.Method1));
            //Task.Run(new Action(asyncAwait.Method1));
            //Task.Factory.StartNew(asyncAwait.Method1);
            //Task.Factory.StartNew(asyncAwait.Method2);
            //Console.WriteLine("Thread in before main: " + Thread.CurrentThread.ManagedThreadId);
            //asyncAwait.Method1();
            //asyncAwait.Method2();
            //Console.WriteLine("Thread in after main: " + Thread.CurrentThread.ManagedThreadId);
            //Console.WriteLine("What's your name?");
            //string str = Console.ReadLine();
            //Console.WriteLine("Your Name " + str);

            //Enums
            Enums enums = new Enums();
            enums.CallEnums();
            Console.Read();


        }
    }

}
