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
            int numberOfSteps = int.Parse(Console.ReadLine());
            int secondForStep = int.Parse(Console.ReadLine());

            long secondsForAllSteps = ((long)numberOfSteps * secondForStep);

            int[] timeToAdd = FindTimeToAdd(secondsForAllSteps);

            TimeSpan time = new TimeSpan(timeToAdd[0], timeToAdd[1], timeToAdd[2]);

            DateTime FinalTime = leavesTime.Add(time);

            string displayTime = FinalTime.ToString("HH:mm:ss");

            Console.WriteLine($"Time Arrival: {displayTime}");



        }

        private static int[] FindTimeToAdd(long seconds)
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

            int[] time = new int[3] { (int)hours, (int)minutes, (int)seconds };

            return time;
        }
    }
}
