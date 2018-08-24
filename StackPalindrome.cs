using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MiroslavD
{
    class StackPalindrome
    {
        public static void Main()
        {
            Stack<char> stack = new Stack<char>();
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            string strToUpper = str.ToUpper();
            foreach(char ch in strToUpper)
            {
                stack.Push(ch);
            }

            bool IsPalindrome = true;
            int ItemsInStack =  stack.Count;
            for(int i = 0; i < ItemsInStack; i++)
            {
                if (strToUpper[i] != stack.Pop())
                {
                    IsPalindrome = false;
                }
            }

            if(IsPalindrome)
            {
                Console.WriteLine("String: '{0}' is a palindrome ", strToUpper);
            }
            else
            {
                Console.WriteLine("String: '{0}' is not a palindrome ",strToUpper);
            }

            Console.WriteLine();








        }
    }
}
