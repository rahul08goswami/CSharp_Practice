using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace PraticeCoding
{
    [Serializable]
    public class Customer : IComparable<Customer>
    {
        public Customer()
        { }
        public Customer(string Name) 
        {
            this.Name = Name;
            Type type = typeof(Customer);
            foreach (PropertyInfo property in type.GetProperties()) // loop using the properties using Reflection
            {
                foreach (Attribute attribute in property.GetCustomAttributes()) //loop custom attributes
                {
                    CheckAttribute c = attribute as CheckAttribute;
                    if (property.Name == "Name")
                    {
                        if ( Name.Length > c.Length)
                            throw new Exception("Name can't be greater than 20");
                    }
                }
            }
        }
        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;
            if (customer.Name == this.Name)
            {
                return true;
            }
            return false;
        }
       // [Check(Length = 20)]
        [StringLength(10)]
        public string Name { get; set; }
       // [Required]
        public string Address { get; set; }

        public int CompareTo(Customer other)
        {
            if (this.Address == other.Address)
            {
                return this.Name.CompareTo(other.Name);
            }
            return this.Address.CompareTo(other.Address);
        }

    }
}
