using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniWaterSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalWater = double.Parse(Console.ReadLine());
            double[] bottles = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double bottleCapacity = double.Parse(Console.ReadLine());

            List<int> emptyBottlesIndex = new List<int>();

            if (totalWater % 2 == 0)  //even - start from 0
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    double currentBottle = bottles[i];

                    FillBottle(ref totalWater, ref currentBottle, bottleCapacity);

                    if (currentBottle != bottleCapacity)
                    {
                        emptyBottlesIndex.Add(i);
                    }
                }
            }

            else    // odd start from bottles.length-1
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    double currentBottle = bottles[i];

                    FillBottle(ref totalWater, ref currentBottle, bottleCapacity);

                    if (currentBottle < bottleCapacity)
                    {
                        emptyBottlesIndex.Add(i);
                    }
                }
            }
            if (emptyBottlesIndex.Count == 0)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {totalWater}l.");
            }
            else
            {
                int amountOfBottles = emptyBottlesIndex.Count;
                double amountOfWaterNeeded = Math.Abs(totalWater);
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {amountOfBottles}");
                Console.WriteLine($"With indexes: {string.Join(", ", emptyBottlesIndex)}");
                Console.WriteLine($"We need {amountOfWaterNeeded} more liters!");
            }
        }

        private static void FillBottle(ref double totalWater, ref double currentBottle, double bottleCapacity)
        {
            if (currentBottle < bottleCapacity)
            {
                double waterNeeded = bottleCapacity - currentBottle;
                if (waterNeeded <= totalWater)
                {
                    totalWater -= waterNeeded;
                    currentBottle = bottleCapacity;
                }
                else
                {
                    totalWater -= waterNeeded;
                }

            }
        }
    }
}
