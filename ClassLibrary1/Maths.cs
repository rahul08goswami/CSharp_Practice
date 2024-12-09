using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Maths
    {
        public int Add(params int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                 sum += i;
            }
            return sum;
        }
    }
}
