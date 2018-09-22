using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class SumDigits
    {
        public static int Sum(int n)
        {
            string str1 = Convert.ToString(n);
            int sum = 0;
            for (int i = 0; i < str1.Length; i++)
                sum += Convert.ToInt32(str1.Substring(i,1));


            return sum;          
        }
        public static void Main()
        {
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("DigitSum: " + Sum(n));
            Console.WriteLine();    
        }
    }
}
