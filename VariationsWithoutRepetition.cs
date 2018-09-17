using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    //  Напишете програма, която прочита цели числа N и K от конзолата и
    //  отпечатва всички вариации от К елемента на числата [1…N].
    class VariationsWithoutRepetition
    {

        const int n = 3;
        const int k = 2;

        static int[] array = new int[k];
        static int[] free = Enumerable.Range(1, 3).ToArray();

        private static void Swap<T>(ref T v1, ref T v2)
        {
            T temp;
            temp = v2;
            v2 = v1;
            v1 = temp;
        }

        public static void PrintVariations()
        {
            Console.WriteLine("(" + string.Join(",",array) + ")");
        }

        public static void GenerateVariationsWithoutRepetitions(int index)
        {
            if(index >= k)
            {
                PrintVariations();
            }
            else
            {
                for(int i = index; i < n; i++)
                {
                    array[index] = free[i];
                    Swap(ref free[i], ref free[index]);
                    GenerateVariationsWithoutRepetitions(index +1);
                    Swap(ref free[i], ref free[index]);                   
                }
            }
        }
        public static void Main()
        {
            GenerateVariationsWithoutRepetitions(0);
        }
    }
}

