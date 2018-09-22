using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace MiroslavD
{
    // Dictionary// 
    class OccurAndSortStringsByDictinaryKey
    {
        private static readonly string TEXT = "Hello word. I am a developer. My name is Miroslav";

        private static IDictionary<string, int> GetWordOccurrence(string text)
        {
            string[] tokens = text.Split(' ', '.', ',', '-', '?', '!');
            IDictionary<string, int> words = new SortedDictionary<string, int>();
            foreach (string word in tokens)
            {
                if (string.IsNullOrEmpty(text.Trim()))
                {
                    continue;
                }
                int count;
                if (words.TryGetValue(word, out count))
                {
                    count = 0;
                }
                words[word] = count + 1;
            }
            return words;
        }
        private static void PrintWordOccurrenceCount(IDictionary<string, int> wordOccurrence)
        {
            foreach (KeyValuePair<string, int> wordEntry in wordOccurrence)
            {
                Console.WriteLine("Value {0} appears {1} time(s).", wordEntry.Key, wordEntry.Value);
            }
            Console.ReadKey();
            Console.WriteLine();
        }
        public static void Main()
        {
            IDictionary<string, int> wordOccurrence = GetWordOccurrence(TEXT);
            PrintWordOccurrenceCount(wordOccurrence);
        }
    }
}
