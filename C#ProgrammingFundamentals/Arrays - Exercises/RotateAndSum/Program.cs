using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int timesToRotete = int.Parse(Console.ReadLine());

            var rotatedArray1 = RotateArrayOnTheRight(arrayOfNums);
            var rotatedArray2 = new int[arrayOfNums.Length];
            var sumOfArrays = new int[arrayOfNums.Length];

            for (int i = 1; i <= timesToRotete; i++)
            {
                sumOfArrays = SumArrays(rotatedArray1, sumOfArrays);
                Array.Copy(rotatedArray1, rotatedArray2, (arrayOfNums.Length));
                rotatedArray1 = RotateArrayOnTheRight(rotatedArray2);
            }
            Console.WriteLine(string.Join(" ", sumOfArrays));

        }

        private static int[] SumArrays(int[] rotatedArray1, int[] sumOfArrays)
        {
            var sum = new int[rotatedArray1.Length];
            for (int i = 0; i < rotatedArray1.Length; i++)
            {
                sum[i] = rotatedArray1[i] + sumOfArrays[i];
            }

            return sum;
        }

        private static int[] RotateArrayOnTheRight(int[] arrayOfNums)
        {
            var rotatedArray = new int[arrayOfNums.Length];
            rotatedArray[0] = arrayOfNums[arrayOfNums.Length - 1];
            for (int i = 0; i < arrayOfNums.Length - 1; i++)
            {
                rotatedArray[i + 1] = arrayOfNums[i];
            }
            return rotatedArray;
        }
    }
}
