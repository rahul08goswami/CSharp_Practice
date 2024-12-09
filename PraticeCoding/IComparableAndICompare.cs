﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    internal class IComparableAndICompare
    {
        private Customer CreateCustomer(string Name, string Address)
        {
            Customer customer = new Customer();
            customer.Name = Name;
            customer.Address = Address;
            return customer;
        }

        public List<Customer> GetCustomer()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(CreateCustomer("Rahul", "Kolkata"));
            customers.Add(CreateCustomer("Debjit", "Hydrabad"));
            customers.Add(CreateCustomer("Arghya", "Hydrabad"));

            customers.Sort();

            return customers;

        }

        public void DisplayCustomers(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer Name: " + customer.Name + " Customer Address: " + customer.Address);
            }
        }


    }
}