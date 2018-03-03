using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string inputData = Console.ReadLine();

                if (inputData == "quit")
                {
                    break;
                }

                string[] inputTokens = inputData
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                string countryName = inputTokens[0];
                string spyName = inputTokens[1];
                int daysInService = int.Parse(inputTokens[2]);

                if (!countries.ContainsKey(countryName))
                {
                    countries[countryName] = new Dictionary<string, int>()
                    {
                        {spyName,daysInService }
                    };
                }
                else
                {
                    countries[countryName][spyName] = daysInService;
                }
            }

            foreach (var country in countries.OrderByDescending(x => x.Value.Count))
            {
                string countryName = country.Key;
                Console.WriteLine($"Country: {countryName}");

                foreach (var spy in country.Value.OrderByDescending(x => x.Value))
                {
                    string spyName = spy.Key;
                    int spyScore = spy.Value;
                    Console.WriteLine($"**{spyName} : {spyScore}");
                }
            }
        }
    }
}
