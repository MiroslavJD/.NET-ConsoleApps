using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class RecursivePalindrome
    {
        public static bool Palindrome(string str)
        {
            if (str.Length <= 2)
                return true;
            else
            {
                if (str[0] != str[str.Length - 1])
                {
                    return false;
                }
                else
                    return Palindrome(str.Substring(str.Length));
            }
        }
        public static void Main()
        {
            Console.WriteLine("String: ");
            string str = Console.ReadLine();

            bool check = Palindrome(str);
            if (check)
            {
                Console.WriteLine("{0} is palindrome ", str);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome ", str);
            }
            Console.WriteLine();
        }
    }
}
