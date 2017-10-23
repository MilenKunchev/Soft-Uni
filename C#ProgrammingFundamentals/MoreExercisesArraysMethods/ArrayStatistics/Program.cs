using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int min = GetMin(arrayOfIntegers);
            int max = GetMax(arrayOfIntegers);
            int sum = GetSum(arrayOfIntegers);
            double average = GetAverage(arrayOfIntegers);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);
        }

        private static double GetAverage(int[] arrayOfIntegers)
        {
            double average = arrayOfIntegers.Average();
            return average;
        }

        private static int GetSum(int[] arrayOfIntegers)
        {
            int sum = arrayOfIntegers.Sum();
            return sum;
        }

        private static int GetMax(int[] arrayOfIntegers)
        {
            int max = arrayOfIntegers.Max();
            return max;
        }

        private static int GetMin(int[] arrayOfIntegers)
        {
            int min = arrayOfIntegers.Min();
            return min;
        }
    }
}
