using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{   // Searching and Sorting Algorithm
   
    public class Program
    {
        // Write a C# Sharp program to sort a list of elements using Bubble sort.
        public static void  Main(string[] args)
        {
          
            Console.Write("Enter elements to store in the array: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            int t;
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("Element{0} ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("\nShow the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            for (int i = 0; i <= array.Length - 2; i++)
            {
                for(int j = 0; j <=  array.Length - 2; j++)
                {
                    if (array[j] > array[j+ 1])
                    {
                        t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.Write("\nSorted array: ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();


        }       
    }
}
 
                 
       
 



 
    

        


