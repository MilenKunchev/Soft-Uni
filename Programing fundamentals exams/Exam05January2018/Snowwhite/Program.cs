using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            Dictionary<string, int> colorsCounter = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                var dwarfsData = input
                     .Split(new char[] { '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();

                AddDwarfToDwarfsList(dwarfsData, dwarfs, colorsCounter);
            }

            PrintResult(dwarfs, colorsCounter);
        }

        private static void PrintResult(List<Dwarf> dwarfs, Dictionary<string, int> colorsCounter)
        {
            List<Dwarf> sorted = dwarfs.OrderByDescending(p => p.Physics).ThenByDescending(c => colorsCounter[c.HatColor]).ToList();

            foreach (var dwarf in sorted)
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }

        private static void AddDwarfToDwarfsList(string[] dwarfsData, List<Dwarf> dwarfs, Dictionary<string, int> colorsCounter)
        {
            string dwarfName = dwarfsData[0].Trim();
            string dwarfHatColor = dwarfsData[1].Trim();
            int dwarfPhysics = int.Parse(dwarfsData[2].Trim());

            if (dwarfs.Any(n => n.Name == dwarfName) && dwarfs.Any(c => c.HatColor == dwarfHatColor))
            {
                Dwarf existingDwarf = dwarfs.First(n => n.Name == dwarfName);

                if (existingDwarf.HatColor == dwarfHatColor)
                {
                    if (existingDwarf.Physics < dwarfPhysics)
                    {
                        existingDwarf.Physics = dwarfPhysics;
                    }
                }
                //
                else
                {
                    Dwarf anyDwarf = new Dwarf();

                    anyDwarf.Name = dwarfName;
                    anyDwarf.HatColor = dwarfHatColor;
                    anyDwarf.Physics = dwarfPhysics;

                    dwarfs.Add(anyDwarf);

                    AddColorToColorsCounter(colorsCounter, dwarfHatColor);
                }

            }
            else
            {
                Dwarf anyDwarf = new Dwarf();

                anyDwarf.Name = dwarfName;
                anyDwarf.HatColor = dwarfHatColor;
                anyDwarf.Physics = dwarfPhysics;

                dwarfs.Add(anyDwarf);

                AddColorToColorsCounter(colorsCounter, dwarfHatColor);

            }
        }

        private static void AddColorToColorsCounter(Dictionary<string, int> colorsCounter, string dwarfHatColor)
        {
            if (!colorsCounter.ContainsKey(dwarfHatColor))
            {
                colorsCounter.Add(dwarfHatColor, 1);
            }
            else
            {
                colorsCounter[dwarfHatColor] += 1;
            }
        }

        class Dwarf
        {
            public string Name { get; set; }
            public string HatColor { get; set; }
            public int Physics { get; set; }
        }
    }
}
