using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(' ').ToArray();
            var secondArray = Console.ReadLine().Split(' ').ToArray();

            int largestCommon = GetLargestCommon(firstArray, secondArray); // Find largest common
            Console.WriteLine(largestCommon);
        }

        private static int GetLargestCommon(string[] firstArray, string[] secondArray)
        {
            int commonCountLeft = 0;
            int commonCountRight = 0;
            int arrayMinLength = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < arrayMinLength ; i++)
            {
                // Left side count
                if (firstArray[i] == secondArray[i])
                {
                    commonCountLeft++;
                }
                // Right side count
                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    commonCountRight++;
                }
            }
            // Check for largest and return result.
            return (commonCountLeft > commonCountRight) ? commonCountLeft : commonCountRight;
        }
    }
}
