using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    internal class Address
    {
        public string StreetName { get; set; }
        public int PinCode { get; set; }
        public int PhoneNumber { get; set; }

        public List<Address> AddressList = new List<Address>();
        public void AddAddress()
        {
            AddressList.Add(new Address { StreetName = "Ramgarh", PinCode = 829122, PhoneNumber = 12345 });
            AddressList.Add(new Address { StreetName = "Kolkata", PinCode = 700102, PhoneNumber = 54321 });
            AddressList.Add(new Address { StreetName = "Jalandhar", PinCode = 144411, PhoneNumber = 12345 });
        }

        //Indexer
        public Address this[int PinCode]
        {
            get
            {
                foreach (Address address in AddressList)
                {
                    if (address.PinCode == PinCode) return address;
                }
                return null;
            }

        }

        public Address this[string PhoneNumbet]
        {
            get
            {
                foreach (Address address in AddressList)
                {
                    if (address.PhoneNumber == Convert.ToInt32(PhoneNumbet)) return address;
                }
                return null;
            }

        }
    }

}
