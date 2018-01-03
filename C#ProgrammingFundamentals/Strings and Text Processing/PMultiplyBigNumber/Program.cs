using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            result = MultiplyNunmbers(firstNumber, secondNumber);

            if (result[0] == '0' && result.Length > 1)
            {
                result = RemoveLeadingZeros(result);
            }
            Console.WriteLine(result);
        }

        private static StringBuilder RemoveLeadingZeros(StringBuilder result)
        {
            while (result[0] == '0' && result.Length > 1)
            {
                result.Remove(0, 1);
            }
            return result;
        }

        private static StringBuilder MultiplyNunmbers(string firstNumber, int secondNumber)
        {
            StringBuilder reversedresult = new StringBuilder();
            int twoDigitResult = 0;
            int remainder = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                double nextDigit = char.GetNumericValue(firstNumber[i]);
                twoDigitResult = (int)nextDigit * secondNumber + remainder;
                remainder = 0;
                if (twoDigitResult > 9)
                {
                    remainder = twoDigitResult / 10;
                    int lastDigit = twoDigitResult % 10;

                    if (i == 0)
                    {
                        reversedresult.Append(lastDigit);
                        reversedresult.Append(remainder);
                    }
                    else
                    {
                        reversedresult.Append(lastDigit);
                    }

                }
                else
                {
                    reversedresult.Append(twoDigitResult);
                }
            }

            StringBuilder result = new StringBuilder();

            for (int i = reversedresult.Length - 1; i >= 0; i--)
            {
                result.Append(reversedresult[i]);
            }
            return result;
        }
    }
}
