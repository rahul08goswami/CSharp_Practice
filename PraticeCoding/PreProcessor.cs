using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    internal class PreProcessor
    {
        public void InPreProcessor()
        {
#if (env32)
            {
#warning This is a waring message
                Console.WriteLine("env32 is enabled");
            }
#endif

#if (x64)
               Console.WriteLine("In x64 Mode");
#endif
            Console.WriteLine("Done");
        }

        [Conditional("env32")]
        public void callMe()
        {
            Console.WriteLine("In Call me");
        }

           

    }
}
