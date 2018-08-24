using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class CustomArrayList
    {
        private object[] array;
        private int count;
        private static readonly int INITIAL_CAPACITY = 4;
        
        public CustomArrayList()
        {
            array = new object[INITIAL_CAPACITY];
            count = 0;
        }

        public  void Add(object item)
        {
            Insert(count, item);
        }

        public  void Insert(int index, object item)
        {
            if(index > count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index input: " + index);
            }
            object[] extendedArr = array;
            if(count + 1 == array.Length)
            {
                extendedArr = new object[array.Length * 2];
            }
            Array.Copy(array, extendedArr, index);
            count++;
            Array.Copy(array, index, extendedArr, index + 1, count - index - 1);
            extendedArr[index] = item;
            array = extendedArr;
        }

        public int IndexOf(object item)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
        public object RemoveAt(int index)
        {
            if(index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index" + index);
            }
            object item = array[index];
            Array.Copy(array, index + 1, array, index, count - index + 1);
            array[count - 1] = null;
            count--;         
            return item;
        }
        public int Remove(object item)
        {
            int index = IndexOf(item);          
            if (index ==  -1)
            {
                return index;            
            }
            Array.Copy(array, index + 1, array, index, count - index + 1);
            count--;
            return index;
        }
        public object this[int index]
        {
            get
            {
                if(index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index " + index);
                }
                return array[index];
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index " + index);
                }
                array[index] = value;
            }                
        }
        public int Count
        {
            get { return count; }
        }
        public void Clear()
        {
            array = new object[INITIAL_CAPACITY];
            count = 0;
        }
        public bool Contains(object item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;
        }
        public static void Main()
        {
            CustomArrayList list = new CustomArrayList();
            list.Add("Item1");
            list.Add("Item2");
            list.Add("Item3");
            list.Add("Item4");
            list.Add("Item5");
            list.Remove("Item4");
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("Does the list contain Item4?" + list.Contains("Item4"));
            Console.WriteLine("Does the list contain Item5?" + list.Contains("Item5"));
        }
    }
}
