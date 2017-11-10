using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();
            var dictionary = new Dictionary<string, int>();

            dictionary = FindWordsCount(words, dictionary);
            PrintKeysWithOddValues(dictionary);
        }

        private static Dictionary<string, int> FindWordsCount(string[] words, Dictionary<string, int> dictionary)
        {
            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary[word] = 1;
                }
            }
            return dictionary;
        }

        static void PrintKeysWithOddValues(Dictionary<string, int> dictionary)
        {
            var output = new List<string>();

            foreach (var word in dictionary)
            {
                if (word.Value % 2 != 0)
                {
                    output.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
