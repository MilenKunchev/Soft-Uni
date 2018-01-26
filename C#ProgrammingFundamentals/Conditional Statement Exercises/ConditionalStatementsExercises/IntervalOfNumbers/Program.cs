using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputOne = int.Parse(Console.ReadLine());
            int inputTwo = int.Parse(Console.ReadLine());

            int firstNumber = Math.Min(inputOne, inputTwo);
            int secondNumber = Math.Max(inputOne, inputTwo);

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
