using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class IdentityMatrixAndDiagonalsOfAMatrix
    { 
        public static void Main()
        {
            decimal sum = 0;
            Console.Write("Enter size of the matrix NxN: ");
            int n = Int32.Parse(Console.ReadLine());
            int m = n;
            decimal[,] matrix = new decimal[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Matrix[{0} {1}] : ", i, j);
                    matrix[i, j] = Convert.ToDecimal(Console.ReadLine());
                    if(j == i)
                    {
                        sum = sum + matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Right diagonal: ");
            Console.WriteLine("Sum of the right diagonal: " + sum);
            Console.WriteLine();
            decimal sumLeft = 0;
            Console.WriteLine("Left Diagonal: ");
            for (int i = 0; i < n; i++) 
            {
                    
                for (int j = 0; j < n; j++)
                {
                    
                    sumLeft = matrix[0, 2] + matrix[1, 1] + matrix[2, 0];
                }
            }
            Console.WriteLine("Sum of left diagonal elements: " + sumLeft);
            Console.WriteLine();
            Console.WriteLine("Left and Right triangular matrix :");

            Console.WriteLine();
            Console.WriteLine("UpperAndLowerTriangularMatrix: "); // You can type in only 1 and get Identity matrix//
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
               for(int j = 0; j < n; j++)
               {
                   if(i <= j && i >= j)
                   {
                       Console.Write("{0} ", matrix[i,j]);
                   }
                   else
                   {
                       Console.Write("{0} ",0);
                   }
               }
            }

            Console.WriteLine();

        }     
    }   
}
