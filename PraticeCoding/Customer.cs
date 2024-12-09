using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    [Serializable]
    public class Customer : IComparable<Customer>
    {
        public string Name { get; set; }
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
