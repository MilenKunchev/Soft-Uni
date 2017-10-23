using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int countOfDiffersnces = 0;
            countOfDiffersnces = CheckForDifferenc(arrayOfNumbers, difference, countOfDiffersnces);
            Console.WriteLine(countOfDiffersnces);
        }

        private static int CheckForDifferenc(int[] arrayOfNumbers, int differents, int countOfDifferences)
        {
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                int firstNumber = arrayOfNumbers[i];
                for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                {
                    int secondnumber = arrayOfNumbers[j];
                    int resultToCheck = Math.Abs(firstNumber - secondnumber);
                    if (differents == resultToCheck)
                    {
                        countOfDifferences++;
                    }
                }
            }
            return countOfDifferences;
        }
    }
}
