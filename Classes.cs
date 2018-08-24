using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;

namespace MiroslavD
{ // static list
    public class CustomArrayList
    {
        class Stack
        {
            int indexx = 0;
            ArrayList list;
            public Stack()
            {
                list = new ArrayList();
                indexx = -1;
            }

            public void Push(object item)
            {
                list.Add(item);
                indexx++;
            }
            public int Count
            {
                get { return list.Count; }
            }

            public object Pop()
            {
                object obj = list[indexx];
                list.RemoveAt(indexx);
                indexx--;
                return obj;
            }
        }
        class IPAdresses : DictionaryBase
        {



            public string ip;
            public string name;

            public void Add(string ip, string name)
            {
                base.InnerHashtable.Add(ip, name);
            }
            public string Item(string name)
            {
                return InnerHashtable[name].ToString();
            }
            public void Remove(string name)
            {
                base.InnerHashtable.Remove(name);
            }
        }
        private object[] arr;
        private int count;

        public int Count
        {
            get { return count; }
        }

        private static readonly int INITIAL_CAPACITY = 4;

        public CustomArrayList()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }

        public void Add(object item)
        {
            Insert(count, item);
        }

        public void Insert(int index, object item)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index: " + index);
            }
            object[] extendedArr = arr; ;
            if (count + 1 == arr.Length)
            {
                extendedArr = new object[arr.Length * 2];
            }
            Array.Copy(arr, extendedArr, index);
            count++;
            Array.Copy(arr, index, extendedArr, index + 1, count - index - 1);
            extendedArr[index] = item;
            arr = extendedArr;
        }
        public int IndexOf(object item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (item == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public void Clear()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }
        public bool Contains(object item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;
        }

        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                return arr[index];
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                arr[index] = value;
            }
        }
        public object RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }
            object item = arr[index];
            Array.Copy(arr, index + 1, arr, index, count - index + 1);
            arr[count - 1] = null;
            count--;

            return item;
        }
        public int Remove(object item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return index;
            }
            Array.Copy(arr, index + 1, arr, index, count - index + 1);
            count--;
            return index;
        }

        public static void Main()
        {

            Stack stack = new Stack();
            stack.Push("HeyStack, Hello");
            while (stack.Count > 0)
            {
                object popitem = stack.Pop();
                Console.WriteLine(popitem);
            }
            CustomArrayList list = new CustomArrayList();
            Console.WriteLine("List with names: ");
            list.Add("Miroslav");
            list.Add("Nadia");
            list.Add("Petrov");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(" " + list[i]);
            }
            Console.WriteLine("Internet Reg ");
            SortedList<string, string> sortedlist = new SortedList<string, string>();
            sortedlist.Add("Miroslav", " 192.59.49.1");
            sortedlist.Add("Nadia", " 192.59.49.25");
            sortedlist.Add("Petrov", " 192.59.49.3");
            foreach (var item in sortedlist)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("IP Address:" + item.Value);
            }
        }
    }
}




         
             
             
             


