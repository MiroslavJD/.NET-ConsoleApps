using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class ShellSortAlgoritm
    {
        public static void Main()
        {
            Console.Write("Enter numbers to store in the array ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            int N = array.Length;
            int K = N / 2;

            Console.WriteLine("Show the elements in the array: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            while (K >= 1)
            {
                K = K / 2;
                for (int i = 0; i < N - K; i++)
                {
                    if (array[i] > array[i + K])
                    {
                        temp = array[i + K];
                        array[i + K] = array[i];
                        array[i] = temp;
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        if (array[j] > array[j + K])
                        {
                            temp = array[j + K];
                            array[j + K] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("\nSorted elements in the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
