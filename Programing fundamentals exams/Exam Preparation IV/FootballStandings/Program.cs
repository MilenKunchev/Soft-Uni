using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FootballStandings
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string[] dataLine = Console.ReadLine().Split().ToArray();

            Dictionary<string, long> standings = new Dictionary<string, long>();
            Dictionary<string, long> goals = new Dictionary<string, long>();

            while (dataLine[0] != "final")
            {
                string firstTeamName = TakeNameFromDataLine(key, dataLine[0]).ToUpper();
                string secondTeamName = TakeNameFromDataLine(key, dataLine[1]).ToUpper();

                firstTeamName = ReverseString(firstTeamName);
                secondTeamName = ReverseString(secondTeamName);

                string[] tokens = dataLine[2].Split(new[] { ' ', ':' }).ToArray();
                long firstTeamGoals = long.Parse(tokens[tokens.Length - 2]);
                long secondTeamGoals = long.Parse(tokens[tokens.Length - 1]);

                // Add team (if dont exist) with zero goals and points.
                AddTeamToStandingsAndGoalsDicts(standings, goals, firstTeamName);
                AddTeamToStandingsAndGoalsDicts(standings, goals, secondTeamName);

                string matchResult = FindResult(firstTeamGoals, secondTeamGoals);
                long firstTeamPoints = 0;
                long secondTeamPoints = 0;

                switch (matchResult)
                {
                    case "1":
                        firstTeamPoints = 3;
                        secondTeamPoints = 0;
                        break;

                    case "2":
                        firstTeamPoints = 0;
                        secondTeamPoints = 3;
                        break;

                    case "x":
                        firstTeamPoints = 1;
                        secondTeamPoints = 1;
                        break;
                }

                goals[firstTeamName] += firstTeamGoals;
                standings[firstTeamName] += firstTeamPoints;

                goals[secondTeamName] += secondTeamGoals;
                standings[secondTeamName] += secondTeamPoints;

                dataLine = Console.ReadLine().Split().ToArray();
            }
            int place = 1;
            Console.WriteLine("League standings:");
            foreach (var team in standings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{place}. {team.Key} {team.Value}");
                place++;
            }
            Console.WriteLine("Top 3 scored goals:");
            place = 0;
            foreach (var team in goals.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
                place++;
                if (place == 3)
                {
                    break;
                }
            }
        }

        private static string TakeNameFromDataLine(string key, string inputString)
        {
            int keyLength = key.Length;
            int nameStartIndex = inputString.IndexOf(key) + keyLength;
            int nameEndIndex = inputString.LastIndexOf(key);
            int elementsTotake = nameEndIndex - nameStartIndex;

            string name = inputString.Substring(nameStartIndex, elementsTotake);
            return name;
        }

        private static string FindResult(long firstTeamGoals, long secondTeamGoals)
        {
            if (firstTeamGoals == secondTeamGoals)
            {
                return "x";
            }
            if (firstTeamGoals > secondTeamGoals)
            {
                return "1";
            }
            else
            {
                return "2";
            }
        }

        private static void AddTeamToStandingsAndGoalsDicts(Dictionary<string, long> standings, Dictionary<string, long> goals, string teamName)
        {
            if (!standings.ContainsKey(teamName))
            {
                standings.Add(teamName, 0);
                goals.Add(teamName, 0);
            }
        }

        static string ReverseString(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
