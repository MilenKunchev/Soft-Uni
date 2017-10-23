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
                if (IsPalindrome(num) && SumOfDigits(num) && ContainsEvenDigit(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        private static bool IsPalindrome(int num)
        {
            string number = num.ToString();
            var reversed = new string(number.Reverse().ToArray());
            var palindrom = number == reversed;
            return palindrom;
        }

        private static bool SumOfDigits(int num)
        {
            string number = num.ToString();
            int sum = 0;
            foreach (var item in number)
            {
                sum += (int)Char.GetNumericValue(item);
            }
            if (sum % 7 == 0)
            {
                return true;
            }

            return false;

        }

        private static bool ContainsEvenDigit(int num)
        {
            string number = num.ToString();
            foreach (var item in number)
            {
                if ((int)Char.GetNumericValue(item) % 2 == 0)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
