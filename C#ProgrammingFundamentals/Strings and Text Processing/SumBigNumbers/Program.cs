using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            if (firstNumber.Length < secondNumber.Length)
            {
                firstNumber = AddZerosToSmallerString(firstNumber, secondNumber);
            }
            else
            {
                secondNumber = AddZerosToSmallerString(secondNumber, firstNumber);
            }

            StringBuilder result = new StringBuilder();
            result = SumNumbers(firstNumber, secondNumber);

            StringBuilder reversedResult = new StringBuilder();

            for (int i = result.Length - 1; i >= 0; i--)
            {
                reversedResult.Append(result[i]);
            }

            if (reversedResult[0] == '0')
            {
                reversedResult = RemoveLeadingZeros(reversedResult);
            }

            Console.WriteLine(reversedResult);
        }

        private static StringBuilder RemoveLeadingZeros(StringBuilder reversedResult)
        {
            while (reversedResult[0] == '0')
            {
                reversedResult.Remove(0, 1);
            }
            return reversedResult;
        }

        private static StringBuilder SumNumbers(string firstNumber, string secondNumber)
        {
            StringBuilder result = new StringBuilder();

            int remainder = 0;
            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                double firstDigit = char.GetNumericValue(firstNumber[i]);
                double secondDigit = char.GetNumericValue(secondNumber[i]);

                int sum = (int)(firstDigit + secondDigit + remainder);

                if (sum > 9)
                {
                    remainder = 1;
                    sum = sum % 10;
                }
                else
                {
                    remainder = 0;
                }

                result.Append(sum);

                if (i == 0 && remainder == 1)
                {
                    result.Append(1);
                }
            }

            return result;
        }

        private static string AddZerosToSmallerString(string smallerString, string biggerString)
        {
            return smallerString.PadLeft(biggerString.Length, '0');
        }
    }
}
