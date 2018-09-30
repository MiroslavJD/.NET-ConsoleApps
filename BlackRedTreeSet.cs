using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MiroslavD
{
    public class TreeSet<T> : ICollection<T>
    {
        private SortedDictionary<T, bool> innerDictionary;
        public TreeSet(IEnumerable<T> elements)
            : this()
        {
            foreach (T item in elements)
            {
                this.Add(item);
            }
        }
        public TreeSet()
        {
            this.innerDictionary = new SortedDictionary<T, bool>();
        }
        public bool Add(T element)
        {
            if (!innerDictionary.ContainsKey(element))
            {
                this.innerDictionary[element] = true;
                return true;
            }
            return false;
        }
        public void IntersectWith(TreeSet<T> other)
        {
            List<T> elementsToRemove = new List<T>(Math.Min(this.Count, other.Count));

            foreach (T key in this.innerDictionary.Keys)
            {
                if (!other.Contains(key))
                {
                    elementsToRemove.Add(key);
                }
            }

            foreach (T elementToRemove in elementsToRemove)
            {
                this.Remove(elementToRemove);
            }
        }

        public void UnionWith(TreeSet<T> other)
        {
            foreach (T key in other)
            {
                this.innerDictionary[key] = true;
            }
        }

        #region ICollection<T> Members
        void ICollection<T>.Add(T item)
        {
            this.Add(item);
        }

        public int Count
        {
            get { return this.innerDictionary.Count; }
        }

        public void Clear()
        {
            this.innerDictionary.Clear();
        }
        public bool Contains(T item)
        {
            return this.innerDictionary.ContainsKey(item);
        }
        public bool Remove(T item)
        {
            return this.innerDictionary.Remove(item);
        }

        public void CopyTo(T[] array, int index)
        {
            this.innerDictionary.Keys.CopyTo(array, index);
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return this.innerDictionary.Keys.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
        {
            return this.innerDictionary.Keys.GetEnumerator();
        }

        #endregion
    }
    public class Program
    {
        public static string GetCommaSeparated(IEnumerable<string> items)
        {
            string result = string.Empty;
            int i = 1;
            foreach (string item in items)
            {
                result += item + ",";
                if (i % 3 == 0)
                {
                    result += Environment.NewLine;
                }
                i++;
            }
            if (result != string.Empty)
            {
                result = result.TrimEnd(' ', '.', '\n', '\r');
            }

            return result;
        }

        public static void Main()
        {
            TreeSet<string> bandsIvanchoLikes = new TreeSet<string>(new[] 
            {
                "Placebo","Nirvana","30 Seconds To Mars","Metallica"
            });
            TreeSet<string> bandsMariikaLikes = new TreeSet<string>(new[]
            {
                "Placebo","Nirvana","Linkin Park","LimpBizkit","Celdweller"
            });

            TreeSet<string> IntersectWith = new TreeSet<string>();
            IntersectWith.UnionWith(bandsIvanchoLikes);
            IntersectWith.IntersectWith(bandsMariikaLikes);

            Console.WriteLine("Bands Ivancho likes: " + GetCommaSeparated(bandsIvanchoLikes));
            Console.WriteLine();
            Console.WriteLine("Bands Mariika likes: " + GetCommaSeparated(bandsMariikaLikes));
            Console.WriteLine();
            Console.WriteLine("Does Ivancho like Mariika? {0} ", IntersectWith.Count > 5 ? "YES" : "NO");

            Console.WriteLine();
        }

    }
} 
       

