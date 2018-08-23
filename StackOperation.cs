using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace MiroslavD
{
    public class StackOperations
    {
        public static bool IsNumeric(string input)
        {
            bool flag = true;
            string pattern = (@"^\d+$");
            Regex validate = new Regex(pattern);
            if (!validate.IsMatch(input))
            {
                flag = false;
            }
            return flag;
        }
        public static void Compute(Stack N, Stack O)
        {
            int opr1 = Convert.ToInt32(N.Pop());
            int opr2 = Convert.ToInt32(N.Pop());
            string opr = Convert.ToString(O.Pop());

            switch(opr)
            {
                case "+" :
                    N.Push(opr1 + opr2);
                    break;
                case "-" :
                    N.Push(opr1-opr2);
                    break;
                case "*" :
                    N.Push(opr1 * opr2);
                    break;
                case "/" :
                    N.Push(opr1 / opr2);
                    break;

            }   
        }
        public static void Calculate(Stack N, Stack O, string exp)
        {
            string ch;
            string token = "";
            for(int i = 0; i < exp.Length; i++)
            {
                ch = exp.Substring(i, 1);
                if(IsNumeric(ch))
                    token += ch;
                if (ch == " " || i == (exp.Length - 1))
                {
                    if (IsNumeric(token))
                        N.Push(token);
                    token = "";
                }
                else if (ch == "+" || ch == "-" || ch == "*" || ch == "/")
                    O.Push(ch);
                if (N.Count == 2)
                    Compute(N, O);
            }
        }
        public static void Main()
        {
            Stack nums = new Stack();
            Stack ops = new Stack();
            string expresion = "131 + 213 + 5";
            Calculate(nums, ops, expresion);
            Console.WriteLine(nums.Pop());

        }
 }
}

