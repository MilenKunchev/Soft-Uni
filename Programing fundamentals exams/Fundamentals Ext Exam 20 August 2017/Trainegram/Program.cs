using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> validTrains = new List<string>();
            // <[{]..[.]..[]..[]..[C2I43].  wrong wagon input .[.].  judge 100/100
            string pattern = @"^(<\[[^a-zA-Z0-9]*?\]\.)(\.\[[a-zA-Z0-9]*?\]\.)*$";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Traincode!")
                {
                    break;
                }

                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    validTrains.Add(input);

                }
            }
            foreach (var train in validTrains)
            {
                Console.WriteLine(train);
            }
        }
    }
}
