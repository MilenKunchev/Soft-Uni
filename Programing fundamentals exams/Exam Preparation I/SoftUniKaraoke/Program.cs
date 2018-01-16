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
            string[] participants = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] songs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, HashSet<string>> awards = new Dictionary<string, HashSet<string>>();

            string stagePerformance = string.Empty;
            while ((stagePerformance = Console.ReadLine()) != "dawn")
            {
                string[] tokens = stagePerformance.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string participant = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!awards.ContainsKey(participant))
                    {
                        awards[participant] = new HashSet<string>() { award };
                    }
                    else
                    {
                        awards[participant].Add(award);
                    }
                }
            }

            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var participant in awards.OrderByDescending(a => a.Value.Count).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                    foreach (var award in participant.Value.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
