using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class ReverseStringRecursively
    {
       public static string ReverseString(string str)
        {
           if(str.Length > 0)
           {
               return  str[str.Length-1] + ReverseString(str.Substring(0, str.Length-1));
           }
           else
           {
               return str;
           }         
        }
       public static void Main()
       {
           Console.Write("String: ");
           string str = Console.ReadLine();
           Console.WriteLine("Reverse string: " + ReverseString(str));
       }
    }   
}         


