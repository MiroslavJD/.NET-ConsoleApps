using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    public class RactangleMatrixAndSubMatrix
    {
       //Да се напише програма, която създава правоъгълна матрица с размер n на m.
      //Размерността и елементите на матрицата да се четат от конзолата.
      //Да се намери подматрицата с размер (3,3), която има максимална сума. 

        public static void Main()
        {

            Console.Write("Enter row: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int m = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("[{0} {1}]: ",i,j);
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ",matrix[i,j]);
                }
            }

            int sum = 0;
            int row = 0;
            int col = 0;

            for(int tempRow = 0; tempRow <  matrix.GetLength(0) -2; tempRow++)
            {
                for(int tempCol = 0; tempCol < matrix.GetLength(1) -2; tempCol++)
                {
                    int tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                  matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                  matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if(tempSum > sum)
                    {
                        row = tempSum;
                        col = tempCol;
                        col = tempCol;
                    }
                        
                }
            }
            Console.WriteLine("Result: ");
            Console.WriteLine("{0} {1} {2}", matrix[row, col], matrix[row, col + 1], matrix[row, col + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[row+1, col], matrix[row+1, col + 1], matrix[row+1, col + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[row+2, col], matrix[row+2, col + 1], matrix[row+2, col + 2]);
            Console.WriteLine("The maximum sum is {0}",sum);
      }
   }
}
