using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int takenPicturesCount = int.Parse(Console.ReadLine());
            long filterTimeInSeconds = long.Parse(Console.ReadLine());
            int goodPicturesPercent = int.Parse(Console.ReadLine());
            long timeToUploadOnePicture = long.Parse(Console.ReadLine());

            long timetoFilter = takenPicturesCount * filterTimeInSeconds;
            double goodPictures = Math.Ceiling((double)takenPicturesCount * goodPicturesPercent / 100);
            long timeToUpload = (long)goodPictures * timeToUploadOnePicture;

            long totalTimeInSeconds = timetoFilter + timeToUpload;

            var days = (totalTimeInSeconds / (24 * 60 * 60));
            var hours = (totalTimeInSeconds / 60 / 60) - days * 24;
            var minutes = (totalTimeInSeconds / 60 - hours * 60 - days * 24 * 60);
            var seconds = totalTimeInSeconds % 60;

            string time = $"{days:d1}:{hours:d2}:{minutes:d2}:{seconds:d2}";

            Console.WriteLine(time);
        }
    }
}
