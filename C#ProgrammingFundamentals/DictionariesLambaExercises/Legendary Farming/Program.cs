using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materialsAndQuantity = new Dictionary<string, int>();
            List<string> input = Console.ReadLine().ToLower().Split().ToList();

            bool haveRequiredElement = false;
            string material = string.Empty;

            while (!haveRequiredElement)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    int quantity = int.Parse(input[i]);
                    i++;
                    material = input[i];
                    AddelementsToDict(materialsAndQuantity, quantity, material);
                    haveRequiredElement = CheckForRequiredElements(materialsAndQuantity, material);
                    if (haveRequiredElement)
                    {
                        break;
                    }
                }
                if (!haveRequiredElement)
                {
                    input = Console.ReadLine().ToLower().Split().ToList();
                }
            }
            string obtainedItem = ObtaineItem(materialsAndQuantity, material);

            SortedDictionary<string, int> elements = new SortedDictionary<string, int>();
            elements["shards"] = 0;
            elements["fragments"] = 0;
            elements["motes"] = 0;
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            SplitMaterials(materialsAndQuantity, elements, junk);
            PrintResult(elements, junk, obtainedItem);

        }

        private static void PrintResult(SortedDictionary<string, int> elements, SortedDictionary<string, int> junks, string obtainedItem)
        {
            Console.WriteLine($"{obtainedItem} obtained!");
            foreach (var element in elements.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
            foreach (var junk in junks)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }

        private static void SplitMaterials(Dictionary<string, int> materialsAndQuantity,
            SortedDictionary<string, int> elements, SortedDictionary<string, int> junk)
        {
            foreach (var material in materialsAndQuantity)
            {
                switch (material.Key)
                {
                    case "shards":
                        elements[material.Key] = material.Value;
                        break;
                    case "fragments":
                        elements[material.Key] = material.Value;
                        break;
                    case "motes":
                        elements[material.Key] = material.Value;
                        break;
                    default:
                        junk[material.Key] = material.Value;
                        break;
                }
            }
        }

        private static string ObtaineItem(Dictionary<string, int> materialsAndQuantity, string material)
        {
            switch (material)
            {
                case "shards":
                    materialsAndQuantity[material] -= 250;
                    return "Shadowmourne";
                case "fragments":
                    materialsAndQuantity[material] -= 250;
                    return "Valanyr";
                case "motes":
                    materialsAndQuantity[material] -= 250;
                    return "Dragonwrath";
            }
            return "Error :)";
        }

        private static bool CheckForRequiredElements(Dictionary<string, int> materialsAndQuantity, string material)
        {
            if (material == "shards" || material == "fragments" || material == "motes")
            {
                if (materialsAndQuantity[material] >= 250)
                {
                    return true;
                }
            }
            return false;
        }

        private static void AddelementsToDict(Dictionary<string, int> materialsAndQuantity, int quantity, string material)
        {
            if (!materialsAndQuantity.ContainsKey(material))
            {
                materialsAndQuantity[material] = quantity;
            }
            else
            {
                materialsAndQuantity[material] += quantity;
            }
        }
    }
}
