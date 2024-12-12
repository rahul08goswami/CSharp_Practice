using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PraticeCoding
{
    internal class AsyncAwait
    {

        public async void Method1()
        {
            await Task.Delay(5000);
            Console.WriteLine("In Method 1");
            Console.WriteLine("Thread in Method 1: "+ Thread.CurrentThread.ManagedThreadId); 
        }
        public async void Method2()
        {
            await Task.Delay(10000);
            Console.WriteLine("In Method 2");
            Console.WriteLine("Thread in Method 2: " + Thread.CurrentThread.ManagedThreadId); 
        }
        public async void CallMethod()
        {
            Console.WriteLine("Calling Long Method");
            await Task.Run(new Action(longRun));
            Console.WriteLine("In Call method");
        }

        void longRun()
        {
            Console.WriteLine("Running long Method");
            //Thread.Sleep(5000);
            Task.Delay(5000).Wait();
            Console.WriteLine("Long Method finishes execution");
        }
    }
}
