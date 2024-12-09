using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace PraticeCoding
{
    public static class ExtensionMentods
    {
        public static int Subtract(this Maths math,params int [] data)
        {
            //int sub = 0;
            //foreach (int i in data)
            //{
            //    int temp = i;
            //    temp -= i;
            //    sub = temp;
            //}
            //return sub;
            int sub =0;
            for (int i = 0; i < data.Length - 1; i++)
            {
                int temp = data[i] - data[i+1];
                sub = temp;
            }
            return sub;
        }

        public static string CallingExten(this String s)
        {
            return "This is getting called from extension method! " + s;
        }

    }
}
