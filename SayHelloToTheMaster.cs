using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class Class
    {
        public static string Name(string name)
        {
            if(name == "Miroslav")
            {
               return "Say Hello!";
            }
            else
            {
                return "That's not the master";
            }
        }
        public static void Main()
        {

            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine(Name(name));  
        }
    }
}
