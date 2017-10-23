using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (var seqNumber in numbersArray)
            {
                double result = RoundingNumbersRedyToPrint(seqNumber);
                string redyToPrint = seqNumber.ToString() + " => " + result.ToString();
                Console.WriteLine(redyToPrint);
            }
        }

        private static double RoundingNumbersRedyToPrint(double seqNumber)
        {
            double result = Math.Abs(seqNumber);
            result += 0.5;
            result = Math.Truncate(result);
            if (seqNumber < 0)
            {
                result *= -1;
            }

            return result;
        }
    }
}
