using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MiroslavD
{ 
    class Class
    {
       public static void PrintMatrix()
        {
            Console.Write("Enter NxN size of the matrix: ");
            int n = Int32.Parse(Console.ReadLine());
            decimal[,]matrix = new decimal[n, n];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("Matrix[{0} {1}] : ", i, j);
                    matrix[i, j] = Convert.ToDecimal(Console.ReadLine());
                    
                }
            }
           for(int i = 0; i < n; i++)
           {
               Console.WriteLine();
               for(int j = 0; j < n; j++)
               {
                   Console.Write("{0} ",matrix[i,j]);
               }
           }
           Console.WriteLine();
        }
       public static void Sum()
       {   
           Console.Write("Enter NxN size of the matrix: ");
           int n = Int32.Parse(Console.ReadLine());
           decimal[,] matrix = new decimal[n,n];
           decimal sum = 0;
           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   Console.Write("Matrix [{0} {1}] ", i,j);
                   matrix[i, j] = Convert.ToDecimal(Console.ReadLine());
                   
               }
           }

           for(int i = 0; i < matrix.GetLength(0); i++)
           {
               Console.WriteLine();
               for(int j = 0; j <  matrix.GetLength(1); j++)
               {
                   Console.Write("{0} ", matrix[i,j]);
               }
           }

           
           List<decimal> list = matrix.OfType<decimal>().ToList();

           for(int i = 0; i < list.Count; i++)
           {               
               sum += list[i];
           }
           Console.WriteLine();
           Console.WriteLine("\nSum matrix: " + sum);
              
       }

       public static void FindMax()
       {
           Console.Write("Enter NxN size of the matrix: ");
           int n = Int32.Parse(Console.ReadLine());
           int[,] matrix = new int[n, n];

           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   Console.Write("Matrix [{0} {1}] ", i, j);
                   matrix[i, j] = Convert.ToInt32(Console.ReadLine());

               }
           }

           for (int i = 0; i < matrix.GetLength(0); i++)
           {
               Console.WriteLine();
               for (int j = 0; j < matrix.GetLength(1); j++)
               {
                   Console.Write("{0} ", matrix[i, j]);
               }
           }
       }
           public static void FindMin()
           {
           Console.Write("Enter NxN size of the matrix: ");
           int n = Int32.Parse(Console.ReadLine());
           int[,] matrix = new int[n,n];
          
           for(int i = 0; i < n; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   Console.Write("Matrix [{0} {1}] ", i,j);
                   matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                   
               }
           }

           for(int i = 0; i < matrix.GetLength(0); i++)
           {
               Console.WriteLine();
               for(int j = 0; j <  matrix.GetLength(1); j++)
               {
                   Console.Write("{0} ", matrix[i,j]);
               }
           }
           
           List<int> list = matrix.OfType<int>().ToList();
           Console.WriteLine("\nMin value in the matrix: ");

           var maxvalue = list.OrderBy(x => x).FirstOrDefault();
           Console.WriteLine("-------------------MinValue-----------------");
           Console.Write(maxvalue);
           Console.WriteLine();
         
              
       }      
       public static void Main()
       {
           Console.WriteLine("Menu: ");
           Console.WriteLine("1.PrintMatrix: ");
           Console.WriteLine("2.Print sum: ");
           Console.WriteLine("3.Max Element: ");
           Console.WriteLine("4.Min Element: ");
           Console.Write("Enter number: ");
           int number = Int32.Parse(Console.ReadLine());
           switch(number)
           {
               case 1:
                   Console.WriteLine("---PrintMatrix metrhod---");
                    Console.Write("Enter numbers to store in the matrix: ");
                    int n = Int32.Parse(Console.ReadLine());
                    decimal[,] matrix = new decimal[n,n];
                    PrintMatrix();
                    break;
               case 2:
                    Console.WriteLine("- Sum method - ");
                    Sum();
                    break;
               case 3:
                    Console.WriteLine("- FindMax method - ");
                    FindMax();
                    break;
               case 4:
                    Console.WriteLine(" - FindMin method - ");
                    FindMin();
                    break;
               default:
                    Console.WriteLine("None");
                    break;
           }
       }
    }
}
