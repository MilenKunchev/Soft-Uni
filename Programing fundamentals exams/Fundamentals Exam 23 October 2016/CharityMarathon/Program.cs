using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {

            long marathonDays = long.Parse(Console.ReadLine());                 // 0-365
            long numberOfRunners = long.Parse(Console.ReadLine());              // 0 - int.max
            long numberOfLapsForEveryRunner = long.Parse(Console.ReadLine());   // 0-100
            long trackLength = long.Parse(Console.ReadLine());                  // 0 - int.max
            long trackCapacity = long.Parse(Console.ReadLine());                // 0-1000
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            long totaltrackCapacity = trackCapacity * marathonDays;

            // If number of runners is bigger then track capacity 
            // Number of runners =  track capacity
            if (numberOfRunners > totaltrackCapacity)
            {
                numberOfRunners = totaltrackCapacity;
            }

            long totalMeters = numberOfRunners * numberOfLapsForEveryRunner * trackLength;
            long totalKilometers = totalMeters / 1000;
            decimal moneyRaisedForTheMarathon = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {moneyRaisedForTheMarathon:f2}");
        }
    }
}
