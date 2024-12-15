using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true,Inherited = true)]
    internal class CheckAttribute: Attribute
    {
        public int Length { get; set; }
    }

    //public class Attributee
    //{
    //    public void callAtt()
    //    {
    //        Customer customer = new Customer();
    //        customer.Name = "Rahullllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll";
    //        try
    //        {
    //            Type type = customer.GetType();
    //            foreach (PropertyInfo property in type.GetProperties()) // loop using the properties using Reflection
    //            {
    //                foreach (Attribute attribute in property.GetCustomAttributes()) //loop custom attributes
    //                {
    //                    CheckAttribute c = attribute as CheckAttribute;
    //                    if (property.Name == "Name")
    //                    {
    //                        if (customer.Name.Length > c.Length)
    //                            throw new Exception("Name can't be greater than 20");
    //                    }
    //                }
    //            }
    //            customer.Name = "Rahul";

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.ToString());
    //        }
    //        Console.WriteLine("Done");
    //    }
    //}
}
    