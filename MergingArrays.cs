using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class MerginArrays
    {
        public static void Main()
        {
            List<int> array = new List<int>();
            List<int> array2 = new List<int>();


            int i, j;
            Console.Write("Enter numbers stored in each array: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Add numbers in array1: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("Number {0} :  ", i);
                int set = Int32.Parse(Console.ReadLine());
                array.Add(set);
            }
            Console.WriteLine("Add numbers in array2: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("Number {0} :  ", i);
                int set2 = Int32.Parse(Console.ReadLine());
                array2.Add(set2);
            }

            List<int> merging = new List<int>();
            merging.AddRange(array);
            merging.AddRange(array2);
            int[] MergedArray = merging.ToArray();
            var acsending = MergedArray.OrderBy(x => x);
            Console.Write("The merged array in acsending order: ");
            foreach (var num in acsending)
            {
                Console.Write(num + " ");
            }
            


            var even =
                from num in MergedArray
                where num % 2 == 0
                select num;

            var odd =
               from num in MergedArray
               where num % 2 != 0
               select num;

            int[] EvenArray = even.ToArray();
            int[] OddArray = odd.ToArray();
            Console.Write("Even: ");
            foreach (var num in EvenArray)
            {
                Console.Write(num + " ");
            }
            Console.Write("\nOdd: ");
            foreach (var num in OddArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }   
    }
}
