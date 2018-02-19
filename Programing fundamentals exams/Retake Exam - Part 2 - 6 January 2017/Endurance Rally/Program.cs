using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Driver> driversList = new List<Driver>();

            string[] driversNames = Console.ReadLine().Split().ToArray();
            double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var driver in driversNames)
            {
                Driver thisDriver = new Driver();
                thisDriver.Name = driver;
                thisDriver.Fuel = driver[0];
                thisDriver.ReachedZone = -1;

                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        thisDriver.Fuel += zones[i];
                    }
                    else
                    {
                        thisDriver.Fuel -= zones[i];
                    }

                    if (thisDriver.Fuel <= 0)
                    {
                        thisDriver.ReachedZone = i;
                        break;
                    }
                }

                driversList.Add(thisDriver);
            }

            foreach (var driver in driversList)
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
    }

    class Driver
    {
        public string Name { get; set; }
        public double Fuel { get; set; }
        public int ReachedZone { get; set; }
    }
}
