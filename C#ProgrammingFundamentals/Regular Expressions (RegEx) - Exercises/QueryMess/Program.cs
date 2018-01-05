using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();



            // Temp variables 
            string anyKeyWord = string.Empty;
            string anyValueWord = string.Empty;

            while (input != "END")
            {
                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();

                string pattern = @"([^&=?\s]*)(?=\=)=(?<=\=)([^&=\s]*)";

                foreach (Match item in Regex.Matches(input, pattern))
                {

                    anyKeyWord = ReplaceSpace(item.Groups[1]);
                    anyValueWord = ReplaceSpace(item.Groups[2]);

                    AddKeyAndValueToResults(results, anyKeyWord, anyValueWord);
                }

                foreach (var item in results)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }
                Console.WriteLine();
                input = Console.ReadLine();

            }

        }

        private static void AddKeyAndValueToResults(Dictionary<string, List<string>> results, string anyKeyWord, string anyValueWord)
        {
            if (!results.ContainsKey(anyKeyWord))
            {
                results[anyKeyWord] = new List<string>();
                results[anyKeyWord].Add(anyValueWord);
            }
            else
            {
                results[anyKeyWord].Add(anyValueWord);
            }

        }

        private static string ReplaceSpace(Group group)
        {
            string matchString = group.ToString();
            string pattern = @"((%20|\+)+)";

            string replacedString = Regex.Replace(matchString, pattern, " ").Trim();

            return replacedString;

        }
    }
}
