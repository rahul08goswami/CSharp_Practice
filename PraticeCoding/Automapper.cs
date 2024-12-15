using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    internal class Automapper
    {
        public void CallMapper()
        {
            Customer customer = new Customer();
            customer.Address = "Kolkata";
            customer.Name = "Rahul";
            Mapper.CreateMap<Customer, Person>();
            Person person = Mapper.Map<Person>(customer);
            Console.Read();

        }
    }
}
