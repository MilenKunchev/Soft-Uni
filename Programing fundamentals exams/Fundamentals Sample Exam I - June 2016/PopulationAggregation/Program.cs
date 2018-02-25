using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryCityCount = new Dictionary<string, int>();
            var cityAndPopulation = new Dictionary<string, long>();

            string inputLine = string.Empty;

            while ((inputLine = Console.ReadLine()) != "stop")
            {
                string[] inputLineTokens = inputLine.Split(new[] { '\\' }).ToArray();
                string country = string.Empty;
                string city = string.Empty;
                long population = long.Parse(inputLineTokens[2]);

                // find country and city names
                if (char.IsLower(inputLineTokens[0], 0))
                {
                    city = inputLineTokens[0];
                    country = inputLineTokens[1];
                }
                else
                {
                    city = inputLineTokens[1];
                    country = inputLineTokens[0];
                }

                // Remove prohibited symbols 
                country = RemoveProhibitedSymbols(country);
                city = RemoveProhibitedSymbols(city);

                AddCountryToDict(countryCityCount, country, city);
                AddCityPopulationToDict(cityAndPopulation, city, population);
            }

            PrintResults(countryCityCount, cityAndPopulation);
        }

        private static void PrintResults(Dictionary<string, int> countryCityCount, Dictionary<string, long> cityAndPopulation)
        {
            foreach (var country in countryCityCount.OrderBy(x => x.Key))
            {
                string countryName = country.Key;
                int citiesCount = country.Value;
                Console.WriteLine($"{countryName} -> {citiesCount}");
            }
            int printConter = 0;
            foreach (var city in cityAndPopulation.OrderByDescending(x => x.Value))
            {
                string cityName = city.Key;
                long cityPopulation = city.Value;
                Console.WriteLine($"{cityName} -> {cityPopulation}");
                printConter++;
                if (printConter == 3)
                {
                    break;
                }
            }
        }

        private static void AddCityPopulationToDict(Dictionary<string, long> cityPopulatuion, string city, long population)
        {
            cityPopulatuion[city] = population;
        }

        static void AddCountryToDict(Dictionary<string, int> countryCityCount, string country, string city)
        {
            if (!countryCityCount.ContainsKey(country))
            {
                countryCityCount[country] = 1;
            }
            else
            {
                countryCityCount[country]++;
            }
        }

        static string RemoveProhibitedSymbols(string word)
        {
            char[] prohibitedSymbols = { '@', '#', '$', '&', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] noProhibitedSymbolsWord = word.Split(prohibitedSymbols);
            return string.Join("", noProhibitedSymbolsWord);
        }
    }
}
