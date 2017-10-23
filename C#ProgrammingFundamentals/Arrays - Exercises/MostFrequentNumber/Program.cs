using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] arrayOfNums = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int number = 0;
            int repeat = 0;
            int maxRepeat = 0;
            for (int i = 0; i < arrayOfNums.Length; i++)
            {
                for (int j = i ; j < arrayOfNums.Length; j++)
                {
                    if (arrayOfNums[i] == arrayOfNums[j])
                    {
                        repeat++;
                    }
                }
                if (repeat > maxRepeat)
                {
                    maxRepeat = repeat;
                    number = arrayOfNums[i];
                }
                repeat = 0;
            }
            Console.WriteLine(number);
        }
    }
}
