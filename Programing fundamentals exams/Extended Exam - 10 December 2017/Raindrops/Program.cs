using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfRegions = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());

            decimal sumcoefficients = 0m;

            for (int i = 0; i < amountOfRegions; i++)
            {
                long[] regionsInformation = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long raindropsCount = regionsInformation[0];
                long squareMeters = regionsInformation[1];

                decimal regionalCoefficient = raindropsCount / (decimal)squareMeters;
                sumcoefficients += regionalCoefficient;
            }
            decimal result = sumcoefficients;
            if (density != 0)
            {
                result = sumcoefficients / density;
            }
            Console.WriteLine($"{result:f3}");
        }
    }
}
