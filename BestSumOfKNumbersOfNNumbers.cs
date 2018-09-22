using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{

//   Да се напише програма, която чете от конзолата две цели числа N и K
//   (K<N), и масив от N елемента. Да се намерят тези K поредни елемента,
//   които имат максимална сума.
    public class BestSumOfKNumbersOfNNumbers
    {
        public static void Main()
        {
            int sum = 0;
            Console.Write("Enter n numbers to store in the array: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter k numbers to store in the array: ");
            int k = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Element {0} : ",i);
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(array, (a, b) => b.CompareTo(a));
            for(int i = 0; i < k; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Best sum : {0} ", sum);

        }
    }
}
