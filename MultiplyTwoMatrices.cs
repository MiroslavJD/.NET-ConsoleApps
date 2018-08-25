using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    public class MultiplyTwoMatrices
    {
        public static void Main()
        {
            int[,] array = new int[50,50];
            int[,] array1 = new int[50, 50];
            int[,] array2 = new int[50, 50];
            int i, j,k;
            int sum = 0;
            
            Console.Write("Rows of the matrix: ");
            int row = Int32.Parse(Console.ReadLine());
            Console.Write("Columns of the matrix: ");
            int col = Int32.Parse(Console.ReadLine());
            for(i = 0; i < row; i++)
            {
                for(j = 0; j < col; j++)
                {
                    Console.Write("Element: [{0},{1}] ", i, j);
                    array[i, j] = Int32.Parse(Console.ReadLine());
                   
                }
            }
            Console.Write("\nThe matrix is: \n");
            for(i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (j = 0; j < col; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                   
                }                   
            }
            Console.Write("\nRows of the matrix1: ");
            int row1 = Int32.Parse(Console.ReadLine());
            Console.Write("Columns of the matrix1: ");
            int col1 = Int32.Parse(Console.ReadLine());
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("Element: [{0},{1}] ", i, j);
                    array1[i, j] = Int32.Parse(Console.ReadLine());

                }
            }
            Console.Write("\nThe second matrix is: \n");
            for (i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (j = 0; j < col; j++)
                {
                    Console.Write("{0} ", array1[i, j]);
                    
                }
            }
          for(i = 0; i < row; i++)
          {
              for(j = 0; j < col1; j++)
              {
                  array2[i, j] = 0;
              }        
          }
          for(i = 0; i < row; i++)
          {
              for(j = 0; j < col1; j++)
              {
                  sum = 0;
                  for (k = 0; k < col; k++)
                  {
                      sum = sum + array[i, k] * array1[k, j];
                      array2[i, j] = sum;
                  }
              }            
          }
          Console.Write("\nThird matrix of multiplication : ");
          for(i = 0; i < row; i++)
          {
              Console.WriteLine();
              for(j = 0; j< col1; j++)
              {
                  Console.Write("{0} ",array2[i,j]);
              }
          }
          Console.WriteLine();
      }   
    }
  }

