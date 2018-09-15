using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    //72. Write a C#Sharp program to display alphabet pattern like M with an asterisk.
    public class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            for(row = 0; row <= 6; row++)
            { 
                for(column = 0; column <= 6; column++)
                {
                    if ((column == 1 && row != 0 &&  row!=6) || (row == 0 && column == 2) || (row == 0 && column == 3) || (row == 0 && column == 4)
                        || (column == 5 && row != 0 && row != 6) || (column == 2 && row == 6) || (column == 3 && row == 6) || (column == 4 && row == 6))
                        
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}







    

   






        


