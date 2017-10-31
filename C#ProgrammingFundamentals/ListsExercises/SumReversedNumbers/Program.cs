using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(' ')
                .ToList();
            List<int> reversedNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string eachElement = numbers[i];
                char[] elements = eachElement.ToCharArray();
                var reversedElements = elements.Reverse().ToArray();
                reversedNumbers.Add(int.Parse(string.Join("", reversedElements)));
            }
            Console.WriteLine(reversedNumbers.Sum());
        }
    }
}
