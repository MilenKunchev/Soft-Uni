using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder firstMatch = new StringBuilder();
            // First pattern and match text.
            string pattern = @"<(p)>(.*?)<\/\1>";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                firstMatch.Append(match.Groups[2].ToString());
            }

            //Second pattern and replace no numbers and not small letters with space
            pattern = @"[^a-z0-9]";

            String secondMatch = Regex.Replace(firstMatch.ToString(), pattern, " ");

            char[] replacedLetters = ReplaceLetters(secondMatch);
            string[] text = new string(replacedLetters).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine(string.Join(" ", text));

        }

        private static char[] ReplaceLetters(string lettersToReplace)
        {
            List<char> replacedLetters = new List<char>();

            foreach (var item in lettersToReplace)
            {
                if (item >= 110 && item <= 122)
                {
                    int letter = item - 13;
                    replacedLetters.Add((char)letter);
                }
                else if (item >= 97 && item <= 109)
                {
                    int letter = item + 13;
                    replacedLetters.Add((char)letter);
                }
                else
                {
                    replacedLetters.Add(item);
                }
            }

            return replacedLetters.ToArray();
        }
    }
}
