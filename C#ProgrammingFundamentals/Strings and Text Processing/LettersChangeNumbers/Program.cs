using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inputLine = Console.ReadLine().Split(new char[] { '\u0009', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            decimal result = 0m;

            for (int i = 0; i < inputLine.Length; i++)
            {
                string nextString = inputLine[i];

                // Split string elements
                char firstLetter = nextString[0];
                char lastLetter = nextString.Last();
                int number = int.Parse(nextString.Remove(nextString.Length - 1, 1).Remove(0, 1));

                // Calculate string result
                result += CalculateStringResult(firstLetter, lastLetter, number);
            }
            Console.WriteLine($"{result:f2}");
        }

        private static decimal CalculateStringResult(char firstLetter, char lastLetter, int number)
        {
            decimal result = 0m;
            // First Letter 

            bool isUppercase = CheckForUpperCase(firstLetter);
            int letterPositionInAlphabet = 0;

            if (isUppercase)
            {
                letterPositionInAlphabet = firstLetter - 64;
                result = (decimal)number / letterPositionInAlphabet;
            }
            else
            {
                letterPositionInAlphabet = firstLetter - 96;
                result = (decimal)number * letterPositionInAlphabet;
            }

            // Last letter 

            isUppercase = CheckForUpperCase(lastLetter);

            if (isUppercase)
            {
                letterPositionInAlphabet = lastLetter - 64;
                result -= letterPositionInAlphabet;
            }
            else
            {
                letterPositionInAlphabet = lastLetter - 96;
                result += letterPositionInAlphabet;
            }
            return result;
        }

        private static bool CheckForUpperCase(char letter)
        {
            bool isUpperCase = (letter >= 65 && letter <= 90);
            return isUpperCase;
        }
    }
}
