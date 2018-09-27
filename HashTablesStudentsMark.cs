using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class HashTablesStudentsMark
    {     
        public static void Main()
        {
            IDictionary<string, double> studentsMark = new Dictionary<string, double>();

            studentsMark["Nadia"] = 6.00;
            studentsMark["Maria"] = 4.00;
            studentsMark["Qroslav"] = 5.00;
            studentsMark["Vesko"] = 6.00;
            studentsMark["Miro"] = 5.50;
            studentsMark["Slav"] = 5.94;


            double MiroMark = studentsMark["Miro"];
            Console.WriteLine("Miro's mark is {0:0.00}", MiroMark);

            studentsMark.Remove("Miro");
            Console.WriteLine("Miro's mark removed");

            Console.WriteLine("Is Miro's mark in the dictionary? {0} ", studentsMark.ContainsKey("Miro") ? "Yes" : "No");

            Console.WriteLine("Slav mark is {0:0.00} ", studentsMark["Slav"]);
            studentsMark["Slav"] = 6.00;
            Console.WriteLine("But we all know he deserves {0:0.00}", studentsMark["Slav"]);

            double BetyMark;
            bool findBetymark = studentsMark.TryGetValue("Bety", out BetyMark);
            Console.WriteLine("Is Bety in the dictionary? {0} ", findBetymark ? "Yes" : "No");
            studentsMark["Bety"] = 5.95;
            findBetymark = studentsMark.TryGetValue("Bety", out BetyMark);
            Console.WriteLine("Let's check again: {0}, Is Bety In the dictionary ? {1} ", findBetymark ? "YES" : "NO", BetyMark);

            foreach(KeyValuePair<string,double> studentMark in studentsMark)
            {
                Console.WriteLine("{0} {1} ", studentMark.Key, studentMark.Value);
            }

            Console.WriteLine("There are {0} students in the dictionary", studentsMark.Count);
            studentsMark.Clear();
            Console.WriteLine("Student dictionary cleared.");
            Console.WriteLine("Is dictionary empty: {0} ", studentsMark.Count == 0);

        }
    }
}
