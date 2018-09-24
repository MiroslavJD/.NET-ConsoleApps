using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class Majorant
    {
           public static bool HasMajorant(int[] array, out int number)
        {
            number = 0;
            int length = array.Length / 2;
            for(int i = 0; i + length < array.Length; i++)
            {
                if(array[i] == array[i+length])
                {
                    number = array[i];
                    return true;
                }
            }
            return false;
        }
       public static void Main(string[] args)
       {
           int[] array = {3,4,4,4,5,6,4,8,4,4,3,4,5,4};
           Array.Sort(array);
           int number;
           bool hasMajorant = HasMajorant(array, out number);
           if(hasMajorant)
           {
               Console.WriteLine("The value '{0}' is majorant.", number);
           }
           else
           {
               Console.WriteLine("There is no majorant in the array.");
           }
           Console.WriteLine();
       }          
   }
}

