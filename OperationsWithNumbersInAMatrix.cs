using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class OperationsWithNumbersInAMatrix
    {     
        static void Main()
        {

            Console.Write("Row: ");
            int row = Int32.Parse(Console.ReadLine());
            Console.Write("Col: ");
            int col = Int32.Parse(Console.ReadLine());
            decimal[,] matrix = new decimal[row, col];
            Console.WriteLine("Create the matrix: ");
            for(int i = 0; i < row ; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Matrix [{0},{1}] ", i, j);
                    matrix[i, j] = Convert.ToDecimal(Console.ReadLine());
                }
            }
            Console.WriteLine("Show the matrix: ");
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= col; j++)
                {
                    Console.Write("{0} ", 4*j + Math.Pow(i,3));
                }
            }
            Console.WriteLine();
            
            List<decimal> list = matrix.OfType<decimal>().ToList();

            decimal[] array = list.ToArray();
            decimal[] negativeValArray = new decimal[array.Length];


            Console.Write("\nNegative values: \n");

            for(int i = 0; i < array .Length; i++)
            {
                if(array [i] < 0)
                {
                    negativeValArray[i] = array[i];
                }
            }

            foreach(var nums in negativeValArray)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine();

            Console.Write("Second way with linq. \nNegative values: ");

            var result =
                from number in array 
                where number < 0
                select number;

            foreach(var num in result)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.Write("Max absolute value: ");
            var maxVal = negativeValArray.OrderByDescending(x => Math.Abs(x)).FirstOrDefault();
            Console.WriteLine(maxVal);


            Console.WriteLine("Products: ");
            var product =
                from positive in list
                from negative in list
                where positive > 0
                where negative < 0
                select new { positive, negative };

           foreach (var nums in product)
           {
               Console.WriteLine("Positive with negative: {0}",nums);
           }

           Console.WriteLine();

                

            

           
        }
    }
}
