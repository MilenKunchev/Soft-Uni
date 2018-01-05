using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> usernames = new List<string>();

            string pattern = @"\b([a-zA-Z]\w{2,24})\b";

            foreach (Match item in Regex.Matches(input, pattern))
            {
                usernames.Add(item.Groups[1].ToString());
            }
            List<string> maxSumUsernames = new List<string>();

            maxSumUsernames = GetMaxSumUsernames(usernames);

            Console.WriteLine(maxSumUsernames[0]);
            Console.WriteLine(maxSumUsernames[1]);
        }

        private static List<string> GetMaxSumUsernames(List<string> usernames)
        {
            List<string> maxSumUsernames = new List<string>();
            int sum = 0;
            string firstUsername = string.Empty;
            string secondUsername = string.Empty;
            for (int i = 1; i < usernames.Count; i++)
            {
                string first = usernames[i - 1];
                string second = usernames[i];

                int currentSum = first.Length + second.Length;

                if (currentSum > sum)
                {
                    sum = currentSum;
                    firstUsername = first;
                    secondUsername = second;
                }
            }
            maxSumUsernames.Add(firstUsername);
            maxSumUsernames.Add(secondUsername);

            return maxSumUsernames;
        }
    }
}
