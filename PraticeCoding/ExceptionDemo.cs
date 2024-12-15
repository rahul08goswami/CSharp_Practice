using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    public class ExceptionDemo
    {
        public void Fun1()
        {
            try
            {
                Console.WriteLine("In Fun1()");
                Fun2();
            }
            catch (Exception ex)
            {

                //throw new Exception(); // Exception showloing
                //throw new Exception("Exception thrown in Fun1" + ex); // Maintains the stacktrace as passing the ex object too
                //throw ex; // Resest the stack Trace
                throw;// Maintains the stacktrace
            }
        }
        private void Fun2()
        {

            Console.WriteLine("In Fun2()");
            throw new Exception();

        }
    }
}
