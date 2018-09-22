using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    public class Program
    {
        // 33. Write a C# Sharp program to display by Pascal's triangle.


        public static void Main(string[] args)
        {
            int c = 1;
            Console.Write("Enter rows: ");
            int rows = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < rows; i++)
            {
                for(int j = 1; j <= rows - i; j++)
                    Console.Write(" ");
                for(int k = 0; k<=i; k++)
                {
                    if (k == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - k + 1) / k;
                    Console.Write("{0} ", c);
                }
                Console.WriteLine();          
            }
        }
    }
}
   


    

   






        


