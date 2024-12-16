using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    public class Generic<Type> where Type : struct
    {
        public bool IsSame(Type par1, Type par2) 
        {
            if (par1.Equals(par2))
                return true;
            return false;
        }
    }
}
