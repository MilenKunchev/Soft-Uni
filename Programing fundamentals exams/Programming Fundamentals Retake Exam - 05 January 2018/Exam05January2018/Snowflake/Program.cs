using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surfaceUp = Console.ReadLine();
            string mantleUp = Console.ReadLine();
            string midlePart = Console.ReadLine();
            string mantleDown = Console.ReadLine();
            string surfaceDown = Console.ReadLine();

            bool surfacesAreValid = CheckSurfaces(surfaceUp, surfaceDown);
            bool mantlesAreValid = CheckMantles(mantleUp, mantleDown);
            bool midlePartIsValid = CheckMidlePart(midlePart);

            bool isValid = surfacesAreValid && mantlesAreValid && midlePartIsValid;

            if (isValid)
            {
                int lengthOfTheCore = FindCoreLength(midlePart);

                Console.WriteLine("Valid");
                Console.WriteLine(lengthOfTheCore);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }

        private static int FindCoreLength(string midlePart)
        {
            Regex rx = new Regex(@"([\W]+)([\d_]+)([a-zA-Z]+)([\d_]+)([\W]+)");
            MatchCollection matches = rx.Matches(midlePart);

            int coreLength = 0;
            foreach (Match match in matches)
            {
                coreLength = match.Groups[3].Length;
            }
            return coreLength;
        }

        private static bool CheckMidlePart(string midlePart)
        {
            Regex rx = new Regex(@"([\W]+[\d_]+[a-zA-Z]+[\d_]+[\W]+)");

            MatchCollection matches = rx.Matches(midlePart);

            int matchLength = 0;

            foreach (Match match in matches)
            {
                matchLength = match.ToString().Length;

            }
            if (matchLength != midlePart.Length)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private static bool CheckMantles(string mantleUp, string mantleDown)
        {
            Regex rx = new Regex(@"([^\d_])");

            MatchCollection matchesUp = rx.Matches(mantleUp);
            MatchCollection matchesDown = rx.Matches(mantleDown);

            if (matchesUp.Count == 0 && matchesDown.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckSurfaces(string surfaceUp, string surfaceDown)
        {
            Regex rx = new Regex(@"(a-zA-Z0-9)");

            MatchCollection matchesUp = rx.Matches(surfaceUp);
            MatchCollection matchesDown = rx.Matches(surfaceUp);

            if (matchesUp.Count == 0 && matchesDown.Count == 0)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
    }
}
