using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skipTakeElements = Console.ReadLine().Split().Select(int.Parse).ToList();
            var cameraString = Console.ReadLine();

            int skipCount = skipTakeElements[0];
            int takeCount = skipTakeElements[1];

            string pattern = @"(\|<[\w]{" + skipCount + @"})([\w]{0," + takeCount + @"})";

            List<string> result = new List<string>();
            foreach (Match item in Regex.Matches(cameraString, pattern))
            {
                result.Add(item.Groups[2].ToString());
            }
            Console.Write(string.Join(", ", result));
        }
    }
}
