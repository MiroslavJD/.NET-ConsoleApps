using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace MiroslavD
{
    //    Напишете програма, която решава следните задачи: 
    // - Обръща последователността на цифрите на едно число. 
    // - Пресмята средното аритметично на дадена поредица от числа. 
    // - Решава линейното уравнение a * x + b = 0.
    //   Създайте подходящи методи за всяка една от задачите. 
    // Напишете програмата така, че на потребителя да му бъде изведено текстово меню,
    // от което да избира коя от задачите да решава.

    class ThreeMethods
    {
        public static int Reverse(int number)
        {
            Console.WriteLine("------------Reverse-----------");
            int sum = 0;
            int k;
            for(int i = number; i != 0; i = i/10)
            {
                k = i % 10;
                sum = sum * 10 + k;
            }
            Console.WriteLine("Reversed number: " + sum);
            return number;
        }

        public static void Average(int[] array)
        {
            Console.WriteLine("------------Average Value-----------");
            Console.Write("Enter elements to store in array: ");
            int n = Int32.Parse(Console.ReadLine());
            array = new int[n];
            double total = 0;         
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element [{0}] : ",i+1);
                array[i] = Int32.Parse(Console.ReadLine());
                total += array[i];
            }
            double average = total/array.Length;
            Console.WriteLine("Average: " + average);
            Console.WriteLine();
        }

        public static double LinearEquation(int a, int x, int b)
        {

            Console.WriteLine("---------Equatioon---------");
            double result = a * x + b;
            Console.WriteLine("Equation: {0}*{1} + {2} = {3} ",a,x,b,result);
            return result;
        }

       

        public static void Main()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1: Reverse program: ");
            Console.WriteLine("2: Average program: ");
            Console.WriteLine("3: Linear equation program: ");
            Console.Write("Enter your choice: ");
            int number = Int32.Parse(Console.ReadLine());

            switch(number)
            {
                case 1:
                     Console.WriteLine("Reverse program: ");
                     Console.Write("Enter number to reverse: ");
                     int numberToReverse = Int32.Parse(Console.ReadLine());
                     Reverse(numberToReverse);
                     break;
                case 2:
                     int[] arr = { 1, 2, 3, 5, 6, 7, 8 };
                     Average(arr);
                    break;
                case 3:                  
                    Console.WriteLine("Create the equation: ");
                    Console.Write("Enter a: ");
                    int a = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter x: ");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter b: ");
                    int b = Int32.Parse(Console.ReadLine());
                    LinearEquation(a, x, b);
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }

            Console.ReadKey();
        }
    }
}
