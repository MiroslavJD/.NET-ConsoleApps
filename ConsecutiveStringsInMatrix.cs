using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiroslavD
{
    class ConsecutiveStringsInMatrix
    {
        //Да се напише програма, която намира най-дългата последователност
        //от еднакви string елементи в матрица. Последователност в матрица
        //дефинираме като елементите са съседни и са на същия ред,колона или
        //диагонал.

        //[ha","re","ho","fi"]
        //["fo","ha","hi","xx"]
        //["xxx","ho","ha","dd"]

       public static void Main(string[] args)
       {
          
          Console.Write("Row: ");
          int row = Int32.Parse(Console.ReadLine());
          Console.Write("Col: ");
          int col = Int32.Parse(Console.ReadLine());

          string[,] matrix = new string[row, col];
          Console.WriteLine("Create the matrix: ");

          for (int i = 0; i < row; i++)
          {
              for(int j =  0; j < col; j++)
              {
                  Console.Write("Matrix[{0},{1}]: ",i,j);
                  matrix[i, j] = Console.ReadLine();
              }
          }
          

          Console.WriteLine("Show the matrix: ");
              for (int i = 0; i < matrix.GetLength(0); i++)
              {
                  Console.WriteLine();
                  for (int j = 0; j < matrix.GetLength(1); j++)
                  {
                      Console.Write("{0} ", matrix[i, j]);
                  }
              }

          Console.WriteLine();
          Console.WriteLine();

          List<string> str = matrix.OfType<string>().ToList();

          // First Way

          Console.WriteLine("Max value in the matrix: ");
          var maxvalue = str.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
          Console.WriteLine(maxvalue);

          Console.WriteLine();
          Console.WriteLine();
          // Second Way

          Console.WriteLine("Values appears in the matrix: ");
          var result =
              from dd in str
              group dd by dd into k
              orderby k.Key descending
              select k;

          foreach (var tt in result)
          {
              Console.WriteLine("{0} - {1}", tt.Key, tt.Count());
          }

          Console.WriteLine();

          // Third Way
          int count = 1;
          int tempCount = 1;
          int number = 0;
          
           for(int i = 0; i < str.Count-1; i++)
           {
               if(str[i].Equals(str[i+1]))
               {
                   tempCount++;
               }
               else
               {
                   tempCount = 1;
               }
               if(tempCount > count)
               {
                   count = tempCount;
                   (number.Equals(str[i])).ToString();
               }
           }
           Console.WriteLine("Most reapted consecutive string in the matrix: ");
           for(int i = 0; i < count; i++)
           {
               Console.WriteLine(str[i]);
           }
           Console.WriteLine();
       }               
   }
}
