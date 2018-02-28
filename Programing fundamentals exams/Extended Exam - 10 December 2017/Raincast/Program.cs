using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            List<string> raincasts = new List<string>();

            bool searchingTheType = true;
            bool searchingTheSource = false;
            bool searchingTheForecast = false;

            string typePattern = @"^Type: (Normal|Warning|Danger)$";
            string sourcePattern = @"^Source: ([a-zA-Z0-9]+)$";
            string forecastPattern = @"^Forecast: ([^,.?!]+)$";

            string type = string.Empty;
            string source = string.Empty;
            string forecast = string.Empty;

            while (inputLine != "Davai Emo")
            {
                if (searchingTheType)
                {
                    var match = Regex.Match(inputLine, typePattern);
                    if (match.Success)
                    {
                        type = match.Groups[1].ToString();
                        searchingTheType = false;
                        searchingTheSource = true;
                    }
                }
                if (searchingTheSource)
                {
                    var match = Regex.Match(inputLine, sourcePattern);
                    if (match.Success)
                    {
                        source = match.Groups[1].ToString();
                        searchingTheSource = false;
                        searchingTheForecast = true;
                    }
                }
                if (searchingTheForecast)
                {
                    var match = Regex.Match(inputLine, forecastPattern);
                    if (match.Success)
                    {
                        forecast = match.Groups[1].ToString();
                        searchingTheType = true;
                        searchingTheSource = false;
                        searchingTheForecast = false;

                        string raincast = $"({type}) {forecast} ~ {source}";
                        raincasts.Add(raincast);
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var raincast in raincasts)
            {
                Console.WriteLine(raincast);
            }
        }
    }
}
