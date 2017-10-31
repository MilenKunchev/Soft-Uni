using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = FindLongestEqualElements(numbers);
            Console.WriteLine(string.Join(" ", result));


        }

        private static List<int> FindLongestEqualElements(List<int> numbers)
        {
            int bestStart = 0;
            int currentStart = 0;
            int count = 1;
            int maxcount = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[currentStart])
                {
                    count++;
                    if (count > maxcount)
                    {
                        maxcount = count;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    count = 1;
                }
            }
            List<int> longestEqualElements = new List<int>(0);
            for (int i = bestStart; i < bestStart + maxcount; i++)
            {
                longestEqualElements.Add(numbers[i]);
            }
            return longestEqualElements;
        }
    }
}
