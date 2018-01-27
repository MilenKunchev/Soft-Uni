using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSeconds = (hours + minutes / 60.0f) + (seconds / 3600.0f);

            float metersPerSecond = (distanceInMeters / 1000) / totalSeconds;
            float kmPerHer = metersPerSecond / 3.6f;
            float milesPerHour = (distanceInMeters / 1609.0f) / totalSeconds;

            Console.WriteLine("{0}", kmPerHer);
            Console.WriteLine("{0}", metersPerSecond);
            Console.WriteLine("{0}", milesPerHour);
        }
    }
}