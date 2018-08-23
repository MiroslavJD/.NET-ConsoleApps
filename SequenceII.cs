using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;

namespace MiroslavD
{
    //Напишете програма, която по даден масив от числа намира мажоранта на масива и го отпечатва.

    public class Program
    {
       public static void Main()
        {
            // N = N + 1;
            // N = N + 2;
            // N = N + 3;

            // Напишете програма, която намира най-кратката поредица от
            // посочените операции, която започва от N и завършва в M.
            // Използвайте опашка.

            // Пример: N = 5, M = 16;
            // Поредицата е: 5 -> 7 -> 8 -> 16;

            int n = 5;
            int p = 16;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int index = 0;
            Console.Write("S = ");

            for(int i = 0; i < queue.Count; i++)
            {
                index++;
                int current = queue.Dequeue();
                Console.Write(" " + current);
                if(current == p)
                {
                    Console.WriteLine();
                    Console.Write("Index = " + index);
                    Console.WriteLine();
                    return;
                }
                queue.Enqueue(current+2);                
                queue.Enqueue((current+3));
                queue.Enqueue((current+3)*2);
               
            }           
        }
    }                      
}   



         
             
             
             


