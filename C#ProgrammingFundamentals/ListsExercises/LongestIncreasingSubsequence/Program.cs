using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] len = new int[numbers.Length];
            int[] prevIndex = new int[numbers.Length];

            int maxlen = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                len[i] = 1;
                prevIndex[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if ((numbers[j] < numbers[i]) && (len[j] + 1 > len[i]))
                    {
                        len[i] = len[j] + 1;
                        prevIndex[i] = j;
                    }
                    if (len[i] > maxlen)
                    {
                        maxlen = len[i];
                        lastIndex = i;
                    }
                }
            }

            List<int> lis = new List<int>();
            if (numbers.Length==1)
            {
                lis.Add(numbers[0]);
            }
            while (lastIndex != -1)
            {
                lis.Add(numbers[lastIndex]);
                lastIndex = prevIndex[lastIndex];
            }

            lis.Reverse();

            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
