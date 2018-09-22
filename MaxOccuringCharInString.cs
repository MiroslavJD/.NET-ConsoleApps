using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class MaxOccuringCharInString
    { 
        public  static string MaxOccuringChar(string str)
        {
            int[] array = new int[120];
            for (int i = str.Length-1; i-- > 0; array[str[i]]++) ;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return (char)maxIndex + " : " + array[maxIndex];
        }

        public static void Main()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Max occuring char is {0} ", MaxOccuringChar(str));

        }
    }
}
