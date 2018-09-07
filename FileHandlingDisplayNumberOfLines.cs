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

    //   Write a program in C# Sharp to count the number of lines in a file. 

    public class Program
    {
        public static void Main()
        {
            string FileName = "HelloWorld.txt";
           
            int count = 0;
            try
            {
                if (File.Exists(FileName))
                {
                    File.Delete(FileName);
                }
                using (StreamWriter StrWriter = File.CreateText(FileName))
                {
                    StrWriter.WriteLine("line number 1");
                    StrWriter.WriteLine("line number 2");
                    StrWriter.WriteLine("line number 3");
                    StrWriter.WriteLine("line number 4");
                    StrWriter.WriteLine("line number 5");
                    StrWriter.WriteLine("line number 6");
                }
                using (StreamReader StrReader = File.OpenText(FileName))
                {
                    string s = "";
                    while ((s = StrReader.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        count++;
                    }
                    Console.WriteLine("The number of lines is {0}",count);
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

    


             
      
    













    







