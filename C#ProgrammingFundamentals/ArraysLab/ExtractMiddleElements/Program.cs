using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            // Array length -> 1
            if (arrayOfNumbers.Length == 1)
            {
                PrintResultForOneElement(arrayOfNumbers);
            }
            // Array length -> odd
            else if (arrayOfNumbers.Length % 2 == 1)
            {
                PrintResultForOddElements(arrayOfNumbers);
            }
            // Array length -> even
            else if (arrayOfNumbers.Length % 2 == 0)
            {
                PrintResultForEvenElements(arrayOfNumbers);
            }

        }

        private static void PrintResultForEvenElements(int[] arrayOfNumbers)
        {
            int n = arrayOfNumbers.Length;
            int firstElement = n / 2 - 1;
            var numsToPrint = new List<int>();
            for (int i = firstElement; i < firstElement + 2; i++)
            {
                numsToPrint.Add(arrayOfNumbers[i]);
            }
            Console.WriteLine("{{ {0} }}", string.Join(", ", numsToPrint));
        }

        private static void PrintResultForOddElements(int[] arrayOfNumbers)
        {
            int n = arrayOfNumbers.Length;
            int firstElement = n / 2 - 1;
            var numsToPrint = new List<int>();
            for (int i = firstElement; i <= firstElement + 2; i++)
            {
                numsToPrint.Add(arrayOfNumbers[i]);
            }
            Console.WriteLine("{{ {0} }}", string.Join(", ", numsToPrint));

        }

        private static void PrintResultForOneElement(int[] arrayOfNumbers)
        {
            Console.WriteLine($"{{ {arrayOfNumbers[0]} }}");
        }
    }
}
