using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{   //Напишете програма, която прочита цяло число N от конзолата и
    //отпечатва всички пермутации на числата [1…N].
    class Permutations
    {
        public static void SwapTheNumbers(ref int a, ref int b)
        {
            int temp;
            temp = b;
            b = a;
            a = temp;
        }
        public static void PrintNumbers(int[] list, int k , int m)
        {
            if(k == m)
            {
                for(int i = 0; i <= m; i++)
                {
                    Console.Write("{0}",list[i]);
                    Console.Write(" ");
                }
            }
            else
            {
                for(int i = k; i <= m; i++)
                {
                    SwapTheNumbers(ref list[k], ref list[i]);
                    PrintNumbers(list, k + 1, m);
                    SwapTheNumbers(ref list[k], ref list[i]);
                }
            }
        }
        public static void Main()
        {
            Console.Write("Enter length of digits: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("Number {0} : ",i+1);
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Permutations are {0}",n);
            PrintNumbers(array, 0, n-1);
            Console.WriteLine();
        }
    }
}
