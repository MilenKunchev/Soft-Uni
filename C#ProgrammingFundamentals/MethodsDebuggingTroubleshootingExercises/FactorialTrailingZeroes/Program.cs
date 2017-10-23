using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= endNumber; i++)
            {
                factorial = CalculateFactorial(factorial, i);
            }
            int zeroCount = FindCоuntZros(factorial);
            PrintRezult(zeroCount);
        }

        private static void PrintRezult(int zeroCount)
        {
            Console.WriteLine(zeroCount);
        }
        private static int FindCоuntZros(BigInteger factorial)
        {
            string factorialToString = factorial.ToString();
            int count = 0;
            for (int i = factorialToString.Length - 1; i >= 0; i--)
            {
                if (factorialToString[i] == '0')
                {
                    count++;
                }
                else
                    return count;
            }
            return count;
        }

        private static BigInteger CalculateFactorial(BigInteger factorial, int i)
        {

            factorial *= i;

            return factorial;
        }
    }
}
