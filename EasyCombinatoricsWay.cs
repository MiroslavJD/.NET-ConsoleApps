using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class EasyCombinatoricsWay
    {
        public static void Main()
        {

            KeyValuePair<int,int>[] array = new KeyValuePair<int,int>[6];
            array[0] = new KeyValuePair<int, int>(1, 1);
            array[1] = new KeyValuePair<int, int>(1, 2);
            array[2] = new KeyValuePair<int, int>(1, 3);
            array[3] = new KeyValuePair<int, int>(2, 2);
            array[4] = new KeyValuePair<int, int>(2, 3);
            array[5] = new KeyValuePair<int, int>(3, 3);

            foreach(var pairs in array)
            {
                Console.WriteLine("({0} {1})", pairs.Value, pairs.Key);
            }
            Console.WriteLine();


            //KeyValuePair<string, string>[] array = new KeyValuePair<string string>[3];
            //array[0] = new KeyValuePair<string, string>("test", "rock");
            //array[1] = new KeyValuePair<string, string>("test", "fun");
            //array[2] = new KeyValuePair<string, string>("rock, "fun");
            
            //foreach (var pairs in array)
            //{
            //    Console.WriteLine("({0} {1})", pairs.Value, pairs.Key);
            //}
            //Console.WriteLine();

        }
    }
}
