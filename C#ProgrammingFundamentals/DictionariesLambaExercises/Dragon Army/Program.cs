using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<int>>> dragonsInfo = new
                Dictionary<string, Dictionary<string, List<int>>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> input = ReadInput();
                AddDragonInfoToDict(input, dragonsInfo);
            }
            Dictionary<string, List<string>> averageStats = new Dictionary<string, List<string>>();
            CalculateAverageStats(averageStats, dragonsInfo);
            PrintResults(averageStats, dragonsInfo);
        }



        private static void PrintResults(Dictionary<string, List<string>> averageStats,
            Dictionary<string, Dictionary<string, List<int>>> dragonsInfo)
        {


            foreach (var type in dragonsInfo)
            {
                // Get key for "averageStats" dict.
                string dragonType = type.Key;
                // Get average stats from "averageStats" dict.
                var average = string.Join("/", averageStats[dragonType]);

                Console.WriteLine($"{type.Key}::({average})");

                //Print dragons names and stats
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, " +
                        $"health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }


        }

        private static void CalculateAverageStats(Dictionary<string, List<string>> averageStats,
            Dictionary<string, Dictionary<string, List<int>>> dragonsInfo)
        {
            foreach (var type in dragonsInfo)
            {
                // create key with dragon type in averageStats Dict.
                if (!averageStats.ContainsKey(type.Key))
                {
                    averageStats[type.Key] = new List<string>();
                }
                int damage = 0;
                int health = 0;
                int armor = 0;
                foreach (var name in type.Value)
                {
                    damage += name.Value[0];
                    health += name.Value[1];
                    armor += name.Value[2];
                }
                // Calculate average stats and round to two after point
                double averageDamage = Math.Round((double)damage / type.Value.Count, 2);
                double averageHealth = Math.Round((double)health / type.Value.Count, 2);
                double averageArmor = Math.Round((double)armor / type.Value.Count, 2);
                // Add average stats and parse them to string with  two triling zeros
                averageStats[type.Key].Add(averageDamage.ToString("0.00"));
                averageStats[type.Key].Add(averageHealth.ToString("0.00"));
                averageStats[type.Key].Add(averageArmor.ToString("0.00"));
            }
        }

        private static void AddDragonInfoToDict(List<string> input,
            Dictionary<string, Dictionary<string, List<int>>> dragonsInfo)
        {
            //{type} {name}                     {damage} {health} {armor}
            List<string> defaultStats = new List<string> { "45", "250", "10" };

            string type = input[0];
            string name = input[1];
            input.RemoveRange(0, 2);

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == "null")
                {
                    input[i] = defaultStats[i];
                }
            }
            List<int> stats = input.Select(int.Parse).ToList();

            if (!dragonsInfo.ContainsKey(type))
            {
                dragonsInfo[type] = new Dictionary<string, List<int>>();
                dragonsInfo[type][name] = stats;
            }
            else
            {
                dragonsInfo[type][name] = stats;
            }
        }

        private static List<string> ReadInput()
        {
            var input = Console.ReadLine().Split().ToList();
            return input;
        }
    }
}