using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));


        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumOfEvens(number);
            int sumOdds = GetSumOfOdds(number);
            int multipleResult = sumEvens * sumOdds;
            return multipleResult;
        }

        private static int GetSumOfOdds(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvens(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
