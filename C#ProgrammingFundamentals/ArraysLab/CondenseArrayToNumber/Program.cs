using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            arrayOfNumbers = ReturnCondenseArrayToNumber(arrayOfNumbers);

            Console.WriteLine(arrayOfNumbers[0]);

        }

        private static int[] ReturnCondenseArrayToNumber(int[] arrayOfNumbers)
        {
            var condensedArray = new int[arrayOfNumbers.Length - 1];
            while (condensedArray.Length >= 1)
            {
                for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
                {
                    condensedArray[i] = arrayOfNumbers[i] + arrayOfNumbers[i + 1];
                }

                Array.Copy(condensedArray, arrayOfNumbers, condensedArray.Length);
                Array.Resize(ref arrayOfNumbers, arrayOfNumbers.Length - 1);
                Array.Resize(ref condensedArray, condensedArray.Length - 1);
            }

            return arrayOfNumbers;
        }
    }
}
