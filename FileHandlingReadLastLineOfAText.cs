using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Collections;
using System.IO;


namespace MiroslavD
{   //File Handling//

    //   Write a program in C# Sharp to create and read the last line of a file.

    public class Program
    {
        public static void Main()
        {
            string FileName = @"HelloWorld.txt";
            try
            {
                if (File.Exists(FileName))
                {
                    File.Delete(FileName);
                }

                Console.Write("Input number of lines to write in the file: ");
                int n = Convert.ToInt32(Console.ReadLine());
                string[] array = new string[n];

                Console.Write("Input {0} strings below :\n", n);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Input line {0} : ", i + 1);
                    array[i] = Console.ReadLine();

                }

                File.WriteAllLines(FileName, array);

                Console.Write("Content of the last line in the file {0} is: \n", FileName);
                if (File.Exists(FileName))
                {
                    string[] lines = File.ReadAllLines(FileName);
                    Console.WriteLine("{0} ", lines[n - 1]);
                }
                Console.WriteLine();

            }
            catch(Exception Exp)
            {
                Console.WriteLine(Exp.ToString());
            }
        }
     }               
}


    


             
      
    













    







