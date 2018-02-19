using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> legionLastActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> legionsSoldiers = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int lastActivity = int.Parse(input[0]);
                string legionName = input[1];
                string soldiersType = input[2];
                long soldiersCount = long.Parse(input[3]);

                AddSoldiersToLegions(legionsSoldiers, legionName, soldiersType, soldiersCount);
                AddLegionsActivity(legionLastActivity, legionName, lastActivity);
            }

            string[] printCommand = Console.ReadLine()
                .Split(new[] { "\\" }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (printCommand.Length == 1)
            {
                string soldierType = printCommand[0];

                foreach (var legion in legionsSoldiers.Where(x => x.Value.ContainsKey(soldierType))
                    .OrderByDescending(x => legionLastActivity[x.Key]))
                {
                    Console.WriteLine($"{legionLastActivity[legion.Key]} : {legion.Key}");
                }
            }
            else
            {
                int activity = int.Parse(printCommand[0]);
                string soldierType = printCommand[1];

                Dictionary<string, long> legionsToPrint = new Dictionary<string, long>();

                foreach (var legion in legionLastActivity.Where(x => x.Value < activity))
                {
                    foreach (var soldier in legionsSoldiers[legion.Key].Where(x => x.Key == soldierType))
                    {
                        if (!legionsToPrint.ContainsKey(legion.Key))
                        {
                            legionsToPrint[legion.Key] = soldier.Value;
                        }
                        else
                        {
                            legionsToPrint[legion.Key] += soldier.Value;
                        }
                    }
                }

                foreach (var legion in legionsToPrint.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{legion.Key} -> {legion.Value}");
                }
            }
        }

        private static void AddLegionsActivity(
            Dictionary<string, int> legionLastActivity,
            string legionName,
            int lastActivity)
        {
            if (!legionLastActivity.ContainsKey(legionName))
            {
                legionLastActivity[legionName] = lastActivity;
            }
            else
            {
                if (legionLastActivity[legionName] < lastActivity)
                {
                    legionLastActivity[legionName] = lastActivity;
                }
            }
        }

        private static void AddSoldiersToLegions(
            Dictionary<string, Dictionary<string, long>> legionsSoldiers,
            string legionName,
            string soldiersType,
            long soldiersCount)
        {
            if (!legionsSoldiers.ContainsKey(legionName))
            {
                legionsSoldiers[legionName] = new Dictionary<string, long>();
                var soldiers = new Dictionary<string, long>();
                soldiers[soldiersType] = soldiersCount;
                legionsSoldiers[legionName] = soldiers;
            }
            else
            {
                if (!legionsSoldiers[legionName].ContainsKey(soldiersType))
                {
                    var soldiers = legionsSoldiers[legionName];
                    soldiers[soldiersType] = soldiersCount;
                }
                else
                {
                    legionsSoldiers[legionName][soldiersType] += soldiersCount;
                }
            }
        }
    }
}
