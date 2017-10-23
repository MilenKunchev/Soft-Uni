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
            long startNumber = long.Parse(Console.ReadLine());
            long endNumber = long.Parse(Console.ReadLine());
            var primeNumsList = new List<long>();
            for (long i = startNumber; i <= endNumber; i++)
            {
                bool isPrime = CheckForPrimeNumber(i);

                if (isPrime)
                {
                    primeNumsList.Add(i);
                }
            }
            Console.WriteLine(string.Join(", ", primeNumsList));
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
