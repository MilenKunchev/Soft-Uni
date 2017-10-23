using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int positionToStop = int.Parse(Console.ReadLine());
            int fibonacciNumber = GetFibonacciNumber(positionToStop);
            Console.WriteLine(fibonacciNumber);
        }

        private static int GetFibonacciNumber(int positionToStop)
        {
            int firstElement = 0;
            int secondElement = 1;
            int fibonacciNumber = 1;
            for (int i = 0; i < positionToStop; i++)
            {
                fibonacciNumber = firstElement + secondElement;
                firstElement = secondElement;
                secondElement = fibonacciNumber;
            }
            return fibonacciNumber;
        }
    }
}
