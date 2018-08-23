using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{   // Strings//
   
    public class Program
    {
        // Write a program in C# Sharp to read a string through the keyboard and sort it using bubble sort.
            //Test Data : 
            //Input number of strings :3 
            //Input 3 strings below : 
            //abcd 
            //zxcv 
            //mnop 
        public static void  Main(string[] args)
        {
            Console.Write("Enter number of strings: ");
            int n = Int32.Parse(Console.ReadLine());
            string[] array = new string[n];
            string temp;
            Console.Write("Create the strings: \n");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", i);
                array[i] = Console.ReadLine();
            }
            Console.Write("Show the strings: \n");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if(array[i].CompareTo(array[j+1]) > 0)
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;

                    }
                }
            }
            Console.Write("\nShow the strings sorted: \n");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            
            
           

            

        }       
    }
}
 
                 
       
 



 
    

        


