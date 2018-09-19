using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MiroslavD
{
        class Numbers
        {
            public int Number;
            public int Index;
            
        }

        class AbsNumbers
        {
            public int AbsValueNumbers;
            public int Index;
        }
    
        class MatricesChoiceAndMinMaxSumAbsValue
        {

            // 1.matrix 4*j + i^3; i < j;
            // 2.matirx 0; i == j; 
            // 3.sum
            // 4.max element;
            // 5.min element;
            // 6.Max absolute value number.
            //1.
            public static void Matrix()
            {

                Console.Write("Enter numbers of rows: ");
                int row = Int32.Parse(Console.ReadLine());
                Console.Write("Enter numbers of col: ");
                int col = Int32.Parse(Console.ReadLine());

                decimal[,] matrix = new decimal[row, col];
                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("Matrix [{0},{1}]: ", i, j);
                        matrix[i, j] = Int32.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();


                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine();
                    for (int j = 1; j <= col; j++)
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
                int row = Int32.Parse(Console.ReadLine());
                Console.Write("Enter numbers of col: ");
                int col = Int32.Parse(Console.ReadLine());

                decimal[,] matrix = new decimal[row, col];
                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("Matrix [{0},{1}]: ", i, j);
                        matrix[i, j] = Int32.Parse(Console.ReadLine());
                    }
                }
                // By condition if we have i==j should print 0;
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
            public static decimal Sum()
            {
                decimal sum = 0;
                Console.Write("Enter numbers of rows2: ");
                int row = Int32.Parse(Console.ReadLine());
                Console.Write("Enter numbers of col2: ");
                int col = Int32.Parse(Console.ReadLine());

                decimal[,] matrix = new decimal[row, col];

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

                decimal[,] matrix = new decimal[row, col];

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

                decimal[,] matrix = new decimal[row, col];

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
            public static void MaxAbsValue()
            {
                List<Numbers> listNumbers = new List<Numbers>();
                listNumbers.Add(new Numbers { Index = 1, Number = 1 });
                listNumbers.Add(new Numbers { Index = 2, Number = 2 });
                listNumbers.Add(new Numbers { Index = 3, Number = -3 });
                listNumbers.Add(new Numbers { Index = 4, Number = -4 });
                listNumbers.Add(new Numbers { Index = 5, Number = -5 });
                listNumbers.Add(new Numbers { Index = 6, Number = 6 });
                listNumbers.Add(new Numbers { Index = 7, Number = 7 });
                listNumbers.Add(new Numbers { Index = 8, Number = 8 });
                listNumbers.Add(new Numbers { Index = 9, Number = 9 });

                Console.WriteLine("Numbers in the list ");
                foreach (var number in listNumbers)
                {
                    Console.WriteLine("Index - {0}, Number - {1} ", number.Index, number.Number);
                }


                List<AbsNumbers> listAbsNumbers = new List<AbsNumbers>();
                listAbsNumbers.Add(new AbsNumbers { Index = 3, AbsValueNumbers = 3 });
                listAbsNumbers.Add(new AbsNumbers { Index = 4, AbsValueNumbers = 4 });
                listAbsNumbers.Add(new AbsNumbers { Index = 5, AbsValueNumbers = 5 });

                Console.WriteLine("Abs Value Numbers");
                foreach(var number in listAbsNumbers)
                {
                    Console.WriteLine("Index - {0}, Abs value of neative number - {1} " , number.Index, number.AbsValueNumbers);
                }

                
              

                Console.Write("Enter rank to show values in the list by: ");
                int rankInTheList = Int32.Parse(Console.ReadLine());

                var result =
                    from num in listNumbers
                    join absolutenumber in listAbsNumbers on num.Index equals absolutenumber.Index
                    select new
                    {
                        Index = num.Index,
                        AbsValueNegativeNumbers = absolutenumber.AbsValueNumbers
                    };

                var rank =
                    (from nums in listAbsNumbers
                     group nums by nums.AbsValueNumbers into g
                     orderby g.Key descending
                     select new
                     {
                         NumbersRec = g.ToList()
                     }).ToList();

                rank[rankInTheList - 1].NumbersRec.ForEach(i => Console.WriteLine("Index: {0}, AbsValueNumber: {1} ",
                    i.Index, i.AbsValueNumbers));
            }
            public static void Main()
            {


                Console.WriteLine("1: Matrix1: 4j + 3^i; i<j");
                Console.WriteLine("2: Matrix2: 0; i==j");
                Console.WriteLine("3: Sum ");
                Console.WriteLine("4: Max ");
                Console.WriteLine("5: Мin ");
                Console.WriteLine("6: Absolute Max Value ");
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
                    case 6:
                        MaxAbsValue();
                        break;
                    default:
                        Console.WriteLine("None");
                        break;
                }
            }
        }
    }
