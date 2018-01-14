using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            string inputLine = string.Empty;

            while ((inputLine = Console.ReadLine()) != "thetinggoesskrra")
            {
                string[] inputParameters =
                    inputLine.Split(new[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputParameters.Length == 1)
                {
                    string dataSet = inputParameters[0];
                    data[dataSet] = new Dictionary<string, long>();
                }

                else
                {
                    string dataKey = inputParameters[0];
                    long dataSize = long.Parse(inputParameters[1]);
                    string dataSet = inputParameters[2];

                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet][dataKey] = dataSize;
                    }

                    else if (!cache.ContainsKey(dataSet))
                    {
                        cache[dataSet] = new Dictionary<string, long>();
                        cache[dataSet][dataKey] = dataSize;
                    }
                    else
                    {
                        cache[dataSet][dataKey] = dataSize;
                    }
                }
            }

            CheckForDataSetInCache(data, cache);

            if (data.Count != 0)
            {
                data = data.OrderByDescending(x => x.Value.Values.Sum())
            .ToDictionary(x => x.Key, x => x.Value);

                KeyValuePair<string, Dictionary<string, long>> result = data.First();

                long totalSize = result.Value.Values.Sum();

                Console.WriteLine($"Data Set: {result.Key}, Total Size: {totalSize}");

                foreach (var item in result.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }


        }

        private static void CheckForDataSetInCache(Dictionary<string, Dictionary<string, long>> data, Dictionary<string, Dictionary<string, long>> cache)
        {
            foreach (var dataSet in cache)
            {
                if (data.ContainsKey(dataSet.Key))
                {
                    data[dataSet.Key] = dataSet.Value;
                }
            }
        }
    }
}
