using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
        // Напишете програма, която прочита цяло число N от конзолата и
        // отпечатва всички комбинации от К елемента на числата [1…N].
    public static class GenerateCombinationsIteratively
    {
       public static IEnumerable<int[]> Combinations(int k, int n)
       {
           var result = new int[k];
           var stack = new Stack<int>();
           stack.Push(1);

           while(stack.Count > 0)
           {
               var index = stack.Count - 1;
               var value = stack.Pop();

               while(value <= n)
               {
                   result[index++] = value++;
                   stack.Push(value);
                   
                   if(index == k)
                   {
                       yield return result;
                       break;
                   }
               }
           }
       }    
       public static void Main()
       {
           Console.Write("Enter n: ");
           var n = Int32.Parse(Console.ReadLine());
           Console.Write("Enter k: ");
           var k = Int32.Parse(Console.ReadLine());

           foreach(var comb in Combinations(k,n))
           {
               Console.WriteLine(string.Join(",",comb));
           }
           Console.WriteLine();
       }
    }   
}
