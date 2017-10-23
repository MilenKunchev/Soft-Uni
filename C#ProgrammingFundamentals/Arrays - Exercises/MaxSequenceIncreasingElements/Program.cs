using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxStart = 0;
            int maxLen = 1;
            int start = 0;
            int len = 1;

            for (int i = 1; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] > arrayOfIntegers[i - 1])
                {
                    len++;
                    if (len > maxLen)
                    {
                        maxLen = len;
                        maxStart = start;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }
            }
            for (int i = maxStart; i < maxStart+maxLen; i++)
            {
                Console.Write($"{arrayOfIntegers[i]} ");
            }
            
        }
    }
}
