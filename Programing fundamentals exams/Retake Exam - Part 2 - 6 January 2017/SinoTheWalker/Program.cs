using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime leavesTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long numberOfSteps = long.Parse(Console.ReadLine());
            long timeForEachStepInSeconds = long.Parse(Console.ReadLine());

            long totalTimeinSeconds = numberOfSteps * timeForEachStepInSeconds;

            TimeSpan neededTime = CalculateNeededTime(totalTimeinSeconds);
            DateTime timeArrival = leavesTime.Add(neededTime);
            string time = timeArrival.ToString("HH:mm:ss");
            Console.WriteLine($"Time Arrival: {time}");
        }

        private static TimeSpan CalculateNeededTime(long seconds)
        {
            long minutes = 0;
            long hours = 0;
            long days = 0;


            long leftSeconds = 0;
            long leftMinutes = 0;
            long leftHours = 0;

            if (seconds > 59)
            {
                minutes = seconds / 60;
                leftSeconds = seconds % 60;
                seconds = 0;
            }
            if (minutes > 59)
            {
                hours = minutes / 60;
                leftMinutes = minutes % 60;
                minutes = 0;
            }
            if (hours > 23)
            {
                days = hours / 24;
                leftHours = hours % 24;
                hours = 0;
            }

            if (seconds == 0) seconds = leftSeconds;
            if (minutes == 0) minutes = leftMinutes;
            if (hours == 0) hours = leftHours;

            TimeSpan time = new TimeSpan((int)hours, (int)minutes, (int)seconds);
            return time;
        }
    }
}
