using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            var counts = new SortedDictionary<double, int>();

            counts = FindCounts(numbers, counts);
            PrintResult(counts);
        }

        private static void PrintResult(SortedDictionary<double, int> counts)
        {
            foreach (var item in counts)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }

        private static SortedDictionary<double, int> FindCounts(List<double> numbers, SortedDictionary<double, int> counts)
        {
            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }
            return counts;
        }
    }
}
