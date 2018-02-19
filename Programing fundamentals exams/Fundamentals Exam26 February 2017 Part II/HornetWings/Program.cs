using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            // An integer indicating the wing flaps, a contestant has chosen to do. [0; 1,000,000,000].
            int wingFlaps = int.Parse(Console.ReadLine());
            // A floating-point number indicating the distance, in meters, the hornet travels for 1000 wing flaps. [0; 1,000,000].
            double distanceFor1000Flaps = double.Parse(Console.ReadLine());
            // How many wing flaps he can make, before he stops to take a break and rest. A hornet rests for 5 seconds. [1; N].
            int endurance = int.Parse(Console.ReadLine());

            int flapPerSecond = 100;

            double distance = ((double)wingFlaps / 1000) * distanceFor1000Flaps;
            int flapsTime = wingFlaps / flapPerSecond;
            int restTime = (wingFlaps / endurance) * 5;
            double totalTime = flapsTime + restTime;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
