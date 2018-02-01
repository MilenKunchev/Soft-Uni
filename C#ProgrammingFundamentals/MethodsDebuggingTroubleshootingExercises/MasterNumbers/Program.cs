using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int num = 1; num <= endNumber; num++)
            {
                if (CheckForPalindrome(num) && CheckForSumOfDigitsDivisibleBy7(num) && ContainsEvenDigit(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        private static bool CheckForPalindrome(int num)
        {
            string number = num.ToString();
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckForSumOfDigitsDivisibleBy7(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num = num / 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ContainsEvenDigit(int num)
        {
            while (num != 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                num = num / 10;
            }
            return false;
        }
    }
}
