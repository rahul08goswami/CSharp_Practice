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
using AutoMapper;
using System.Diagnostics;
using System.Collections;

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

            //foreach (MemberInfo member in parameterType.GetMembers())
            //{
            //    Console.WriteLine(member.Name);
            //}
            //int res = parameterType.InvokeMember("Add", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Instance
            //    , null, obj, null);

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
            //Enums enums = new Enums();
            //enums.CallEnums();

            //var x = new { Value = 1 }; var y = new { Value = 1 }; Console.WriteLine(x == y);// False

            //MSMQ
            //MSMQ mSMQ = new MSMQ();
            //mSMQ.SendMessage();
            //mSMQ.ReadMessage();

            //Attribute
            //Customer customer = new Customer("Testttttttttttttttttttttttttttttttttttttttttttt");
            //customer.Name = "Testtttttttttttttttttttttttttttttttttttttttttttttt"; 
            //Attributee attributee = new Attributee();
            //attributee.callAtt();

            //AutoMapper
            //Automapper mapper = new Automapper();
            //mapper.CallMapper();

            //Data Annotation
            //DataAnnotation dataAnnotation = new DataAnnotation();
            //dataAnnotation.callAnnotation();

            //Random and Guid
            //Random random = new Random();
            //Console.WriteLine(random.Next(100, 200));
            //Guid guid = Guid.NewGuid();
            //Console.WriteLine(guid.ToString("N")); //N - No Space  B - Brace

            //Exception
            //ExceptionDemo exceptionDemo = new ExceptionDemo();
            //exceptionDemo.Fun1();

            //Preprocessor Derectives
            //PreProcessor processor = new PreProcessor();
            //processor.InPreProcessor();
            //processor.callMe();
            //#if (x64)
            //            Console.WriteLine("In x64 Mode");
            //#endif
            //            Console.WriteLine("Done");

            //Threading
            Threading threading = new Threading();
            //Thread thread = new Thread(threading.Divide);
            //thread.Start();
            //threading.Divide();
            //Mutex -- Restrict external thread only 1 thread can be executed
            //threading.Muteex();
            //Sepmapjore -- Multiple External thread can run withing a limit
            //threading.Semaphorre();

            //AutoResetEvent -> For Every WaitOne a Set is require to send signal
            //threading.AutoResetEventt();
            //ManualResetEven --> 1 Set for all WaitOne
            //threading.ManualResetEventt();

            //Thread Pool
            //threading.Result();
            //threading.TPLResult();

            //Collection
            //Collection collection = new Collection();
            //collection.ArrayList();
            //collection.HastTable();
            //collection.Queuee(); //FIFO
            //collection.stack(); //LIFO

            //Generics
            //Generic<int> generic = new Generic<int>();
            //Generic<string> g = new Generic<string>();
            //Console.WriteLine(generic.IsSame(2, 2));
            //Console.WriteLine(g.IsSame("Rahul","Rahul"));

            //IEnumrable
            Customer customer = new Customer();
            //customer.Address = "Delhi";
            //customer.Name = "Aryan";
            //IEnumerable temp = customer.LoadCustomers(); // Can iterate the collection only
            //ICollection temp = customer.LoadCustomers(); // Can iterate the collection and see the count as well
            //IList temp = customer.LoadCustomers(); // Gives Full access in caller and retuens ArrayList
            //IDictionary temp = customer.LoadCustomersWithDic(); // Gives Full access in caller and retuens HasTable
            //IEnumerable temp = customer.LoadCustomersWithDic(); // Gives Full access in caller and retuens HasTable
            //temp.Add(customer);

            //Console.WriteLine(temp.Count);

            //foreach (var item in temp)
            //{
            //    Customer cust = (Customer)item;
            //    Console.WriteLine(cust.Address);
            //}

            // Iterate HasTable
            //for (int i = 1; i <= temp.Count; i++)
            //{
            //    Customer c = temp["Cust" + i] as Customer;
            //    Console.WriteLine(c.Address);
            //}

            customer.IEnumerableIterate();
            customer.IEnumeratorIerate();

            Console.Read();


        }

    }

}
