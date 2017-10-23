using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool elementExists = false;
            int positionOfElement = 0;
            for (positionOfElement = 0; positionOfElement < arrayOfNumbers.Length; positionOfElement++)
            {
                leftSum = GetLeftsum(arrayOfNumbers, positionOfElement);
                rightSum = GetRightSum(arrayOfNumbers, positionOfElement);

                if (leftSum == rightSum)
                {
                    elementExists = true;
                    break;
                }
            }
            if (elementExists)
            {
                Console.WriteLine(positionOfElement);
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private static int GetRightSum(int[] arrayOfNumbers, int positionOfElement)
        {
            int rightSum = 0;
            if (positionOfElement == arrayOfNumbers.Length - 1)
            {
                return rightSum;
            }
            for (int i = positionOfElement + 1; i < arrayOfNumbers.Length; i++)
            {
                rightSum += arrayOfNumbers[i];
            }
            return rightSum;
        }

        private static int GetLeftsum(int[] arrayOfNumbers, int positionOfElement)
        {
            int leftSum = 0;
            if (positionOfElement == 0)
            {
                return leftSum;
            }
            else
            {
                for (int i = 0; i < positionOfElement; i++)
                {
                    leftSum += arrayOfNumbers[i];
                }
            }
            return leftSum;
        }
    }
}
