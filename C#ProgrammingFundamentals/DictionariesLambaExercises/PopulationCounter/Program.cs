using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populationReport = new
                Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine().Split('|').ToList();
            while (input[0] != "report")
            {
                AddDataToDict(input, populationReport);

                input = Console.ReadLine().Split('|').ToList();
            }
            PrintResult(populationReport);
        }

        private static void PrintResult(Dictionary<string,
            Dictionary<string, long>> populationReport)
        {
            populationReport = populationReport.OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var country in populationReport)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }

        private static void AddDataToDict(List<string> input, Dictionary<string,
            Dictionary<string, long>> populationReport)
        {
            string city = input[0];
            string country = input[1];
            int population = int.Parse(input[2]);

            if (!populationReport.ContainsKey(country))
            {
                populationReport[country] = new Dictionary<string, long>();
                populationReport[country][city] = population;
            }
            else
            {
                populationReport[country][city] = population;
            }
        }
    }
}
