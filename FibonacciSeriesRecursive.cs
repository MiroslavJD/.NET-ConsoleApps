using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Collections;

namespace MiroslavD
{   // Strings
    // Factorial recursive.
 
    public class TestClass
    {     
        public static uint Factorial(uint n)
        {
               if(n == 0)
               {
                   return 1;
                  
               }
               else
               {
                   return n * Factorial(n - 1);
               }
        }
        public static void Main()
        {
            Console.Write("Enter number: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Factorial of {0} is {1}", n, Factorial(n));
            Console.WriteLine();         
        }
    }
}




