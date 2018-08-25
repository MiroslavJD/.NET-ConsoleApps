using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class DIamond
    {
        static void Main(string[] args)
        {
            Console.Write("Ente rows: ");
            int row = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= row; i++)
            {
                for (int j = 1; j <= row - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            for (int i = row - 1; i >= 1; i--)
            {
                for (int j = 1; j <= row - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
