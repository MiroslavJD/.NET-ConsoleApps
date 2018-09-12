using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{   //Напишете програма, която прочита от конзолата масив от цели числа и
    //премахва минимален брой числа, така че останалите числа да са
    //сортирани в нарастващ ред. Отпечатайте резултата.
    class WholeArray
    {
        public int ArrNumber;
        public int ItemID;
    }
    class AscendingArray
    {
       
        public int Number;
        public int ItemID;
    }

    public class ArrNumbersAscendingOrder
    {
        public static void Main()
        {
            List<WholeArray> arrayList = new List<WholeArray>();
            arrayList.Add(new WholeArray { ItemID = 1, ArrNumber = 1 });
            arrayList.Add(new WholeArray { ItemID = 2, ArrNumber = 5 });
            arrayList.Add(new WholeArray { ItemID = 3, ArrNumber = 3 });
            arrayList.Add(new WholeArray { ItemID = 4, ArrNumber = 6 });
            arrayList.Add(new WholeArray { ItemID = 5, ArrNumber = 4 });
            arrayList.Add(new WholeArray { ItemID = 6, ArrNumber = 8 });
            arrayList.Add(new WholeArray { ItemID = 7, ArrNumber = 3 });
            arrayList.Add(new WholeArray { ItemID = 8, ArrNumber = 5 });

            foreach(var item in arrayList)
            {
                Console.WriteLine("ItemId: {0}, ArrNumbers: {1} ",item.ItemID, item.ArrNumber);
            }
            Console.WriteLine();
            List<AscendingArray> ascendingOrder = new List<AscendingArray>();
            ascendingOrder.Add(new AscendingArray { ItemID = 1, Number = 1 });
            ascendingOrder.Add(new AscendingArray { ItemID = 2, Number = 3 });
            ascendingOrder.Add(new AscendingArray { ItemID = 3, Number = 6 });
            ascendingOrder.Add(new AscendingArray { ItemID = 4, Number = 8 });

            foreach (var item in ascendingOrder)
            {
                Console.WriteLine("ItemId: {0}, AscendingOrder: {1} ", item.ItemID, item.Number);
            }

            Console.WriteLine();
            var result =
                from number in arrayList
                join num in ascendingOrder on number.ItemID equals num.ItemID
                select new
                {
                    ItemID = number.ItemID,              
                    Numbers = num.Number
                };
            Console.WriteLine("ItemID\t\tAcsendingOrder");
            foreach(var data in result)
            {
                Console.WriteLine(data.ItemID + "\t\t" + data.Numbers);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }



}
