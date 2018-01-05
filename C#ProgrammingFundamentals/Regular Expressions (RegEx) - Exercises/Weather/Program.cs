using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([A-Z]{2})([0-9]{1,2}[.][0-9]{1,2})([a-zA-Z]+)([|])";

            string cityName = string.Empty;
            double temperature = 0;
            string typeOfWeather = string.Empty;

            Dictionary<string, CityWeather> cities = new Dictionary<string, CityWeather>();

            while (input != "end")
            {
                foreach (Match matches in Regex.Matches(input, pattern))
                {
                    cityName = matches.Groups[1].ToString();
                    temperature = double.Parse(matches.Groups[2].ToString());
                    typeOfWeather = matches.Groups[3].ToString();

                    cities[cityName] = new CityWeather();
                    cities[cityName].AverageTemperature = temperature;
                    cities[cityName].WeatherType = typeOfWeather;
                }

                input = Console.ReadLine();
            }
            foreach (var city in cities.OrderBy(x => x.Value.AverageTemperature))
            {
                Console.WriteLine($"{city.Key} => {city.Value.AverageTemperature:f2} => {city.Value.WeatherType}");
            }
        }

        class CityWeather
        {
            public double AverageTemperature { get; set; }
            public string WeatherType { get; set; }
        }
    }
}
