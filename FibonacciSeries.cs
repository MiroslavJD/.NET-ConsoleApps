using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class FibonacciSeries
    {
        public static int Fibbonaci(int n)
        {
            int temp;
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                temp = b;
                b = a;
                a = a + temp;
            }
            return a;
        }
        public static void Main()
        {
            Console.Write("Enter number: " );
            int number = Int32.Parse(Console.ReadLine());

            for(int i = 1; i < number; i++)
            {
                Console.WriteLine("Fibbonaci series: " + Fibbonaci(i));
            }
            Console.WriteLine();
        }
    }
}
