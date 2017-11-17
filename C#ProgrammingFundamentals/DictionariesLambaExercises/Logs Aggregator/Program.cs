using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> logData = new
                Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> logInformation = Console.ReadLine().Split().ToList();

                string ipAdres = logInformation[0];
                string username = logInformation[1];
                int duration = int.Parse(logInformation[2]);

                AddDataToDictionary(logData, ipAdres, username, duration);
            }
            PrintResult(logData);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> logData)
        {

            foreach (var user in logData.OrderBy(x => x.Key))
            {
                int commaCounter = 0;
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");

                foreach (var userData in user.Value.OrderBy(x => x.Key))
                {
                    Console.Write($"{userData.Key}");

                    int countOfIpAddresses = user.Value.Count;
                    if (commaCounter < countOfIpAddresses - 1)
                    {
                        Console.Write(", ");
                        commaCounter++;
                    }
                }
                Console.WriteLine("]");
            }
        }

        private static void AddDataToDictionary(Dictionary<string, Dictionary<string, int>> logData
            , string ipAdres, string username, int duration)
        {
            if (!logData.ContainsKey(username))
            {
                logData[username] = new Dictionary<string, int> { { ipAdres, duration } };
            }
            else if (!logData[username].ContainsKey(ipAdres))
            {
                logData[username][ipAdres] = duration;
            }
            else
            {
                logData[username][ipAdres] += duration;
            }
        }
    }
}
