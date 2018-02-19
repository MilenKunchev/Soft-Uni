using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowwhite_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<KeyValuePair<string, string>, int> dwarfs = new Dictionary<KeyValuePair<string, string>, int>();
            Dictionary<string, int> colorsCounter = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                String[] tokens = input.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                AddDwarfsToDict(tokens, dwarfs, colorsCounter);
            }
            var sortedDwarfs = dwarfs.OrderByDescending(d => d.Value)
                .OrderByDescending(x => colorsCounter[x.Key.Value])
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in sortedDwarfs)
            {
                string name = item.Key.Key;
                string hatColor = item.Key.Value;
                int physics = item.Value;
                Console.WriteLine($"({hatColor}) {name} <-> {physics}");
            }


        }

        private static void AddDwarfsToDict(string[] tokens, Dictionary<KeyValuePair<string, string>, int> dwarfs,
            Dictionary<string, int> colorsCounter)
        {
            string dwarfName = tokens[0];
            string dwarfHatColor = tokens[1];
            int dwarfPhysics = int.Parse(tokens[2]);

            KeyValuePair<string, string> anyDwarf = new KeyValuePair<string, string>(dwarfName, dwarfHatColor);

            if (dwarfs.ContainsKey(anyDwarf) && dwarfs[anyDwarf] < dwarfPhysics)
            {
                dwarfs[anyDwarf] = dwarfPhysics;
            }
            else if (!dwarfs.ContainsKey(anyDwarf))
            {
                dwarfs[anyDwarf] = dwarfPhysics;

                // Add dwarf hat color to colorsCounter 
                if (!colorsCounter.ContainsKey(dwarfHatColor))
                {
                    colorsCounter[dwarfHatColor] = 1;
                }
                else
                {
                    colorsCounter[dwarfHatColor] += 1;
                }
            }
        }
    }
}
