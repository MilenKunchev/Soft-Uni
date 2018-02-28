using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            var creaturesSquadMate = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input[0] == "Blaze it!")
                {
                    break;
                }

                string creature = input[0];
                string squadMate = input[1];

                if (creature.Equals(squadMate))
                {
                    continue;
                }

                AddCreaturesAndSquadMAte(creaturesSquadMate, creature, squadMate);
            }
            RemoveCreaturesInSquad(creaturesSquadMate);

            foreach (var creature in creaturesSquadMate.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{creature.Key} : {creature.Value.Count}");
            }
        }

        static void RemoveCreaturesInSquad(Dictionary<string, HashSet<string>> creaturesSquadMate)
        {
            foreach (var creature in creaturesSquadMate)
            {
                string creatureName = creature.Key;

                foreach (var mateName in creature.Value)
                {
                    if (creaturesSquadMate.ContainsKey(mateName) && creaturesSquadMate[mateName].Contains(creatureName))
                    {
                        creaturesSquadMate[creatureName].Remove(mateName);
                        creaturesSquadMate[mateName].Remove(creatureName);
                        break;
                    }
                }
            }
        }

        static void AddCreaturesAndSquadMAte(Dictionary<string, HashSet<string>> creaturesSquadMate,
           string creature,
           string squadMate)
        {
            if (!creaturesSquadMate.ContainsKey(creature))
            {
                creaturesSquadMate[creature] = new HashSet<string>();
                creaturesSquadMate[creature].Add(squadMate);
            }
            else
            {
                creaturesSquadMate[creature].Add(squadMate);
            }


        }
    }
}
