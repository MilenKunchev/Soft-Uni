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
            Console.WriteLine(factorial);
        }

        private static BigInteger CalculateFactorial(BigInteger factorial, int i)
        {

            factorial *= i;

            return factorial;
        }
    }
}
