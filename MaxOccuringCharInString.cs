using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{   // Strings
   
    public class Program
    {
        // Write a program in C# Sharp to sort a string array in ascending order    
        public static void  Main(string[] args)
        {
            int i, j;
            char[] array;
            char ch;
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            int l = str.Length;
            array = str.ToCharArray(0, l);
            for(i=1;i<l;i++)
                for(j=0;j<l-i;j++)
                    if(array[j]>array[j+1])
                    {
                        ch = array[j+1];
                        array[j+1] = array[j];
                        array[j] = ch;
                    }
            Console.Write("\nAfter sorting the string appears like: \n");
            foreach(char c in array)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.WriteLine();






        }       
    }
}
 
                 
       
 



 
    

        


