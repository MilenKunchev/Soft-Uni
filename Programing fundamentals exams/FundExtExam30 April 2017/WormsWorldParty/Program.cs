using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorldParty
{
    class Program
    {
        static void Main(string[] args)
        {                   //          teamName         wormName wormScope
            var teams = new Dictionary<string, Dictionary<string, long>>();
            var worms = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }
                string[] inputTokens = input
                .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

                string wormName = inputTokens[0];
                string teamName = inputTokens[1];
                long wormScore = long.Parse(inputTokens[2]);

                if (worms.Contains(wormName))
                {
                    continue;
                }

                worms.Add(wormName);

                if (!teams.ContainsKey(teamName))
                {
                    teams[teamName] = new Dictionary<string, long>()
                    {
                        {wormName,wormScore }
                    };
                }
                else
                {
                    teams[teamName][wormName] = wormScore;
                }
            }
            var sortedTeams = teams
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Sum() / x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            int counter = 1;
            foreach (var team in sortedTeams)
            {
                long totalScope = team.Value.Values.Sum();
                Console.WriteLine($"{counter}. Team: {team.Key} - {totalScope}");
                counter++;

                foreach (var worm in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
            }
        }
    }
}
