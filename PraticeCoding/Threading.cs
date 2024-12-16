using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace PraticeCoding
{
    internal class Threading
    {
        int Num1;
        int Num2;
        Random random = new Random();
        Semaphore s;
        public void Divide()
        {
            //lock (this)
            //{
            Monitor.Enter(this);
            for (long i = 0; i < 10000; i++)
            {
                Num1 = random.Next(1, 5);
                Num2 = random.Next(1, 5);
                Console.WriteLine("Num1 = " + Num1);
                Console.WriteLine("Num2 = " + Num2);
                int res = Num1 / Num2;
                Num1 = 0;
                Num2 = 0;
            }
            Monitor.Exit(this);

            // }
        }

        public void Muteex()
        {
            using (var m = new Mutex(false, "Threading"))
            {
                if (!m.WaitOne(5000, false))
                {
                    Console.WriteLine("Already an instance is running");
                    Console.Read();
                    return;
                }
                Console.WriteLine("App Running!");
                Console.Read();
            }
        }

        public void Semaphorre()
        {
            try
            {
                s = Semaphore.OpenExisting("Sema");
                Console.WriteLine("Open Existing");

            }
            catch (Exception)
            {

                s = new Semaphore(2, 2, "Sema");
                Console.WriteLine("Creating New");

            }
            Console.WriteLine("Acquiring!");
            s.WaitOne();
            Console.WriteLine("Thread Acquired!");
            Console.ReadLine();
            s.Release();

        }

        AutoResetEvent autoReset = new AutoResetEvent(false);
        ManualResetEvent manualReset = new ManualResetEvent(false);
        public void AutoResetEventt()
        {
            new Thread(Display).Start();
            Console.WriteLine("Starting");
            autoReset.WaitOne();
            Console.WriteLine("Done hai ji");
            autoReset.WaitOne();
            Console.WriteLine("Done hai ji");
        }
        public void ManualResetEventt()
        {
            new Thread(Display).Start();
            Console.WriteLine("Starting");
            manualReset.WaitOne();
            Console.WriteLine("Done hai ji");
            manualReset.WaitOne();
            Console.WriteLine("Done hai ji");
        }

        private void Display()
        {
            // Console.WriteLine("In Display Method");
            //Console.ReadLine();
            //manualReset.Set();
            //autoReset.Set();
            //Console.ReadLine();
            //autoReset.Set();
        }

        private void RunMillionTimes()
        {
            string c = "";
            for (int i = 0; i < 100; i++)
            {
                c += "x";
            }
        }

        Stopwatch stopwatch = new Stopwatch();

        public void TPLResult()
        {

            //Task task = new Task(RunMillionTimes);
            stopwatch.Start();
            // Parallel.For(0, 0, (x) => RunMillionTimes());
            //task.Start();
            //new Task(() => RunMillionTimes()).Start();
            //task.Wait();
            for (int i = 0; i < 100; i++)
            {
                Task.Run(() => RunMillionTimes()).Wait();
            }
            stopwatch.Stop();
            Console.WriteLine("Result with TPL: " + stopwatch.ElapsedTicks);
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < 100; i++)
            {
            Thread thread = new Thread(RunMillionTimes);
            thread.Start();                
            thread.Join(); // Wait for the thread to complete
            }
            stopwatch.Stop();
            Console.WriteLine("Result without TPL: " + stopwatch.ElapsedTicks);

        }
        public void Result()
        {
            for (int i = 0; i < 10; i++)
            {
                WithPool();
                WithOutPool();
            }
            Console.WriteLine("Starting WithPool: ");
            stopwatch.Start();
            WithPool();
            stopwatch.Stop();
            Console.WriteLine("Result withPool: " + stopwatch.ElapsedTicks);
            stopwatch.Reset();
            Console.WriteLine("Starting WithoutPool: ");
            stopwatch.Start();
            WithOutPool();
            Console.WriteLine("Result without Pool: " + stopwatch.ElapsedTicks);
        }
        private void WithPool()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem((o) => Display());
            }
        }

        private void WithOutPool()
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(() => Display()).Start();
            }
        }
    }
}
