using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Collections;

namespace MiroslavD
{   
 
    public class FibonacciNumbersRecusively
    {     
        public static int Fibonacci(int n)
        {
               if(n <= 2)
               {
                   return 1;
                  
               }
               else
               {
                   return Fibonacci(n - 1) + Fibonacci(n - 2);
               }
        }
        public static void Main()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibboanaci number: " + Fibonacci(number));
            Console.WriteLine();         
        }
    }
}




