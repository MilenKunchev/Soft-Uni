using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRange = int.Parse(Console.ReadLine());
            for (int number = 2; number <= numberRange; number++)
            {
                bool isPrime = true;
                for (int numbersToCheck = 2; numbersToCheck <= Math.Sqrt(number); numbersToCheck++)
                {
                    if (number % numbersToCheck == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }


        }
    }
}
