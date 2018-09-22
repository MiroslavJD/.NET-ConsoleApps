using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiroslavD
{
//    Да се напише програма, която сравнява два масива от тип char
//    лексикографски (буква по буква) и проверява кой от двата е по-рано
//    в лексикографската подредба.

    public  class CompareArraysLexicographically
    {
        public static void Main()
        {
            char[] array = { 'a', 'b', 'c', 'z' };
            int arraylength = array.Length;
            char[] array2 = { 'b', 'z', 't', 'u' };
            int array2length = array2.Length;

            int length = Math.Min(arraylength, array2length);

            
                if(arraylength > array2length)
                {
                    Console.WriteLine("Array2 is lexicographically earlier");
                }
                else if (arraylength == array2length)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (array[i] > array2[i])
                        {
                            Console.WriteLine("Array2 is lexicographically earlier");
                            break;
                        }
                        else if (array[i] < array2[i])
                        {
                            Console.WriteLine("Array1 is lexicographically earler");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Array1 is lexicographically equal to Array2");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Array1 is lexicographically earlier");
                }
            }
        }  
    }
