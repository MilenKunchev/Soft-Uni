using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var counter = new int[1001];
            for (int i = 0; i < numbers.Count; i++)
            {
                counter[numbers[i]]++;
            }
            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] != 0)
                {
                    Console.WriteLine($"{i} -> {counter[i]}");
                }
            }
        }
    }
}
