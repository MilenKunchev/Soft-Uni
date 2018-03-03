using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplinterTrip
{
    class Program
    {
        private static double milesInHeavyWinds;

        static void Main(string[] args)
        {
            double travelDistanceInMiles = double.Parse(Console.ReadLine());
            double fuelTankCapacity = double.Parse(Console.ReadLine());
            double milesInheavyWinds = double.Parse(Console.ReadLine());

            double milesInNonHeavyWinds = travelDistanceInMiles - milesInheavyWinds; // No heavy winds miles.
            double consumptionNonHeavyWinds = milesInNonHeavyWinds * 25; // Non heavy winds fuel.
            double consumptionHeavyWinds = milesInheavyWinds * (25 * 1.5); // Heavy winds fuel.
            double fuelConsumption = consumptionHeavyWinds + consumptionNonHeavyWinds; // Consumption fuel.
            double tolerance = fuelConsumption * 0.05; // Fuel tolerance.
            double totalFuelConsumption = tolerance + fuelConsumption; // Total fuel needed.
            double remainingFuel = fuelTankCapacity - totalFuelConsumption;

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
            if (remainingFuel < 0)
            {
                double fuelNeeded = Math.Abs(remainingFuel);
                Console.WriteLine($"We need {fuelNeeded:f2}L more fuel.");
            }
            else
            {
                Console.WriteLine($"Enough with {remainingFuel:f2}L to spare!");
            }
        }
    }
}
