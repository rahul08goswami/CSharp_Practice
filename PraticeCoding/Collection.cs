using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    internal class Collection
    {
        public void ArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(0);
            arrayList.Add("Rahul");
            Console.WriteLine(arrayList[0].ToString() + arrayList[1]);
        }

        public void HastTable()
        {
            Customer customer = new Customer();
            customer.Name = "Rahul";
            customer.Address = "Kolkata";
            Hashtable ht = new Hashtable();
            ht.Add(customer.Name, customer);
            Customer ct = ht["Rahul"] as Customer;
            Console.WriteLine(ct.Address);
        }

        public void Queuee()
        {
            Customer customer = new Customer();
            customer.Name = "Rahul";
            customer.Address = "Kolkata";
            Queue queue = new Queue();
            queue.Enqueue("Rahul");
            queue.Enqueue(customer);
            Console.WriteLine(queue.Dequeue());
            Customer cut = queue.Dequeue() as Customer;
            Console.WriteLine(cut.Name);
        }

        public void stack()
        {
            Stack stack = new Stack();
            stack.Push("Rahul");
            Customer customer = new Customer();
            customer.Name = "Rahul";
            customer.Address = "Kolkata";
            stack.Push(customer);
            Customer c = stack.Pop() as Customer;
            Console.WriteLine(c.Address);
            Console.WriteLine(stack.Pop());
        }
    }
}
