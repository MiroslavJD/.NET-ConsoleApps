using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    class DynamicList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return element; }
                set { element = value; }
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            public Node(object element, Node prevNode)
            {
                this.element = element;
                prevNode.next = this;
            }
            public Node(object element)
            {
                this.element = element;
                next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
        {
            if (head == null)
            {
                head = new Node(item);
                tail = head;
            }
            else
            {
                Node newNode = new Node(item, tail);
                tail = newNode;
            }
            count++;
        }
        public object RemoveAt(int index)
        {
            if (index > count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invaldi index: " + index);
            }
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;
            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }
            count--;
            if (count == 0)
            {
                head = null;
            }
            else if (prevNode == null)
            {
                head = currentNode.Next;
            }
            else
            {
                prevNode.Next = currentNode.Next;
            }
            Node lastElement = null;
            if (this.head != null)
            {
                lastElement = this.head;
                while (lastElement.Next != null)
                {
                    lastElement = lastElement.Next;
                }
            }
            tail = lastElement;
            return currentNode.Element;
        }
        public int Remove(object item)
        {
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;
            while (currentNode != null)
            {
                if ((currentNode.Element != null && currentNode.Element.Equals(item)) || (currentNode.Element == null) && (item == null))
                {
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }
            if (currentNode != null)
            {
                count--;
                if (count == 0)
                {
                    head = null;
                }
                else if (prevNode == null)
                {
                    head = currentNode.Next;
                }
                else
                {
                    prevNode.Next = currentNode.Next;
                }
                Node lastElement = null;
                if (this.head != null)
                {
                    lastElement = this.head;
                    while (lastElement.Next != null)
                    {
                        lastElement = lastElement.Next;
                    }
                }
                tail = lastElement;
                return currentIndex;
            }
            else
            {
                return -1;
            }
        }
        public int IndexOf(object item)
        {
            int index = 0;
            Node current = head;
            while (current != null)
            {
                if ((current.Element != null && current.Element == item) || (current.Element == null) && (item == null))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }
        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invlid index " + index);
                }
                Node currentNode = this.head;
                for(int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode.Element;
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invlid index " + index);
                }
                Node currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Element = value;
            }
        }
        public bool Contains(object item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;
        }

        public int Count
        {
            get { return count; }
        }

        public static void Main()
        {
            DynamicList list = new DynamicList();
            list.Add("Item1");
            list.Add("Item2");
            list.Add("Item3");
            list.Add("Item4");
            list.Add("Item5");
            list.Remove("Item5");
            Console.WriteLine("Items in list: ");
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("Does the list contain Item5 " + list.Contains("Item5"));
            Console.WriteLine("Does the list contain Item4 " + list.Contains("Item4"));

            Console.WriteLine();
        }
    }
}
