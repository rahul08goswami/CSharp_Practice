using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    internal class Yield
    {
        public List<int> list = new List<int>();

        public void FillValues()
        {
            list.Add(0);
            list.Add(2);
            list.Add(5);
            list.Add(7);
            list.Add(9);
        }

        public void Display(List<int> list)
        {
            foreach (int i in RunningTotal(list))
            {
                Console.WriteLine(i);
            }
        }

        IEnumerable<int> Filter(List<int> list)
        {
            foreach (int i in list)
            {
                if (i >= 3) yield return i;
            }
        }
        IEnumerable<int> RunningTotal(List<int> list)
        {
            int Running = 0;
            foreach (int i in list)
            {
                Running += i;
            }
            yield return Running;
        }
        //IEnumerable<int> Filter (List<int> list)
        //{
        //    List<int> temp = new List<int>();
        //    foreach (int i in list)
        //    {
        //        if(i>=3) temp.Add(i);
        //    }
        //    return temp;
        //}
    }
}
