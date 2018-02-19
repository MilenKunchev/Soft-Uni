using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] availableSongs = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            Dictionary<string, HashSet<string>> awards = new Dictionary<string, HashSet<string>>();

            string performance = Console.ReadLine();

            while (performance != "dawn")
            {
                string[] performanceTokens = performance
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

                string participant = performanceTokens[0];
                string song = performanceTokens[1];
                string award = performanceTokens[2];

                if (participants.Contains(participant) && availableSongs.Contains(song))
                {
                    if (!awards.ContainsKey(participant))
                    {
                        awards[participant] = new HashSet<string>();
                        awards[participant].Add(award);
                    }
                    else
                    {
                        awards[participant].Add(award);
                    }
                }
                performance = Console.ReadLine();
            }

            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            else
            {
                foreach (var participant in awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                    foreach (var award in participant.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
