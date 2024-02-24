using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    internal class ExitProgram
    {
        public static void WaitForAnyKeyToExit()
        {
            Console.WriteLine("\nPress any key to exit..."); 
            Console.ReadKey(); 
        }
    }
}
