using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            bool isPrime = CheckForPrimeNumber(number);
            Console.WriteLine(isPrime);

        }

        private static bool CheckForPrimeNumber(long number)
        {
            if (number < 2)
            {
                return false;
            }
            int maxNumberToCheck = (int)Math.Sqrt(number);
            for (int i = 2; i <= maxNumberToCheck; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }

            }
            return true;


        }
    }
}
