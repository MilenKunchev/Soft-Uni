using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] driversLine = Console.ReadLine().Split().ToArray();
            double[] track = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<Driver> drivers = new List<Driver>();

            AddDriversAdnFuel(drivers, driversLine, track, checkpoints);

            PrintResults(drivers);


        }

        private static void PrintResults(List<Driver> drivers)
        {
            foreach (var driver in drivers)
            {
                if (driver.ReachedZone < 0)
                {
                    Console.WriteLine($"{driver.Name} - fuel left {driver.Fuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{driver.Name} - reached {driver.ReachedZone}");
                }
            }
        }

        private static void AddDriversAdnFuel(List<Driver> drivers, string[] driversLine, double[] track, int[] checkpoints)
        {
            foreach (var driver in driversLine)
            {
                Driver anydriver = new Driver();
                anydriver.Name = driver;
                int StartFuel = driver[0];
                anydriver.Fuel = StartFuel;
                anydriver.ReachedZone = -1;

                CalculateFuel(anydriver, track, checkpoints);

                drivers.Add(anydriver);
            }
        }

        private static void CalculateFuel(Driver anydriver, double[] track, int[] checkpoints)
        {
            for (int zone = 0; zone < track.Length; zone++)
            {
                if (checkpoints.Contains(zone))
                {
                    anydriver.Fuel += track[zone];
                }
                else
                {
                    anydriver.Fuel -= track[zone];

                    if (anydriver.Fuel <= 0)
                    {
                        anydriver.ReachedZone = zone;
                        break;
                    }
                }
            }
        }

        class Driver
        {
            public string Name { get; set; }
            public double Fuel { get; set; }
            public int ReachedZone { get; set; }
        }
    }
}
