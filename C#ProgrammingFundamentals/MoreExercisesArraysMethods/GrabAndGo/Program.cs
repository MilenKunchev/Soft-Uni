using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberToSearch = int.Parse(Console.ReadLine());
            int numberIndex = 0;
            numberIndex = GetNumberIndex(arrayOfIntegers, numberToSearch);
            if (numberIndex == 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                long sum = 0;
                sum = SumNumbers(arrayOfIntegers, numberIndex);
                Console.WriteLine(sum);
            }

        }

        private static long SumNumbers(int[] arrayOfIntegers, int numberIndex)
        {
            long sum = 0;
            for (int i = 0; i < numberIndex; i++)
            {
                sum += arrayOfIntegers[i];
            }
            return sum;
        }

        private static int GetNumberIndex(int[] arrayOfIntegers, int numberToSearch)
        {
            int numberIndex = 0;            
            for (int i = arrayOfIntegers.Length-1; i >=0 ; i--)
            {
                if (arrayOfIntegers[i]==numberToSearch)
                {
                    numberIndex = i;
                    return numberIndex;
                }
            }
            return numberIndex;
        }
    }
}
