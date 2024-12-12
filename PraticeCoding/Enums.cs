using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    internal class Enums
    {
        [Flags]
        public enum MyColurs
        {
            Red =1, Green =2, Blue =3, White =4, Magenta =5
        };

        public void CallEnums()
        {
            //MyColurs colurs = MyColurs.Blue | MyColurs.White;
            //if((MyColurs.White & colurs) == MyColurs.White)
            //    Console.WriteLine("White");
            //Console.WriteLine(colurs);

            Console.WriteLine("Enter a color");
            string str = Console.ReadLine();
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), str); //Takes a string or num and convert to an enum
            Console.WriteLine("Is the color proper?" + (ConsoleColor)Enum.Parse(typeof(ConsoleColor), str));
        }
    }
}
