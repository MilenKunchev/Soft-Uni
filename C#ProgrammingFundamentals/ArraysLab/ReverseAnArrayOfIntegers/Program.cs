using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIntegers = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[numberOfIntegers];

            for (int i = 0; i < numberOfIntegers; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numberOfIntegers - 1; i >= 0; i--)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }

        }
    }
}
