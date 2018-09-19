using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class MatricesChoiceAndMinMaxSum
    {
        // 1.matrix 4*j + i^3; i < j;
        // 2.matirx 0; i == j; 
        // 3.sum
        // 4.max element;
        // 5.min element;
        //1.
        public static void Matrix()
        {
            Console.Write("Enter numbers of rows: ");
            decimal row = Int32.Parse(Console.ReadLine());
            Console.Write("Enter numbers of col: ");
            decimal col = Int32.Parse(Console.ReadLine());
            for (decimal i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (decimal j = 1; j <= col; j++)
                {
                    Console.Write("{0} ", 4 * j + i * i * i);
                }
            }
            Console.WriteLine();

        }
        //2.
        public static void Matrix2()
        {

            Console.Write("Enter numbers of rows: ");
            decimal row = Int32.Parse(Console.ReadLine());
            Console.Write("Enter numbers of col: ");
            decimal col = Int32.Parse(Console.ReadLine());
            for (decimal i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (decimal j = 1; j <= col; j++)
                {
                    Console.Write("{0} ", 0);
                }
            }
            Console.WriteLine();

        }
        //3.
        public static int Sum()
        {
            int sum = 0;
            Console.Write("Enter numbers of rows2: ");
            int row = Int32.Parse(Console.ReadLine());
            Console.Write("Enter numbers of col2: ");
            int col = Int32.Parse(Console.ReadLine());
            
            int [,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("Elements [{0},{1}] ", i, j);
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                    sum += matrix[i, j];
                }
            }

            return sum;
            
        }
        //4.
        public static void MaxElement()
        {
            
            Console.Write("Enter numbers of rows: ");
            int row = Int32.Parse(Console.ReadLine());
            Console.Write("Enter numbers of col: ");
            int col = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("Elements [{0},{1}] ", i, j);
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                  
                }
            }
            List<int> maxElement = matrix.OfType<int>().ToList();
            var max = maxElement.OrderByDescending(x => x).FirstOrDefault();
            Console.WriteLine("Max: " + max);
        }
        //5.
        public static void MinElement()
        {
           
            Console.Write("Enter numbers of rows: ");
            int row = Int32.Parse(Console.ReadLine());
            Console.Write("Enter numbers of col: ");
            int col = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("Elements [{0},{1}] ", i, j);
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            List<int> minElement = matrix.OfType<int>().ToList();
            var min = minElement.OrderBy(x => x).FirstOrDefault();
            Console.WriteLine("Min: " + min);
            

        }

        public static void Main()
        {
            Console.WriteLine("1: Matrix1: 4j + 3^i; i<j");
            Console.WriteLine("2: Matrix2: 0; i==j");
            Console.WriteLine("3: Sum ");
            Console.WriteLine("4: Max ");
            Console.WriteLine("5: Мin ");
            Console.Write("Enter choice: ");
            int number = Int32.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Matrix();
                    break;
                case 2:
                    Matrix2();
                    break;
                case 3:
                    Sum();
                    break;
                case 4:
                    MaxElement();
                    break;
                case 5:
                    MinElement();
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }
        }
    }
}
