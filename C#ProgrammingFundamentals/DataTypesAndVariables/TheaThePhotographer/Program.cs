using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPicturs = int.Parse(Console.ReadLine());
            int filterTimeInSeconds = int.Parse(Console.ReadLine());
            int goodPicturesPersentage = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long timeToFilterInSeconds = (long)numberOfPicturs * filterTimeInSeconds;

            double goodPictures = Math.Ceiling(((double)numberOfPicturs * goodPicturesPersentage) / 100);

            long goodPictUploadTime = (long)goodPictures * uploadTime;

            long totalTime = timeToFilterInSeconds + goodPictUploadTime;

            string orderTime = ConvertTime(totalTime);

            Console.WriteLine(orderTime);
        }

        private static string ConvertTime(long seconds)
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
            //----------------------------------------
            if (seconds == 0) seconds = leftSeconds;
            if (minutes == 0) minutes = leftMinutes;
            if (hours == 0) hours = leftHours;

            string time = $"{days:d1}:{hours:d2}:{minutes:d2}:{seconds:d2}";
            return time;
        }
    }
}
