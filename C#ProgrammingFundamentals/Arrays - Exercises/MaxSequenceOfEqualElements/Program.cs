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
            int[] arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 0;

            for (int pos = 1; pos < arrayOfIntegers.Length; pos++)
            {
                if (arrayOfIntegers[pos] == arrayOfIntegers[pos - 1])
                {
                    len++;
                }
                else
                {
                    start = pos;
                    len = 1;
                }
                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(arrayOfIntegers[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
