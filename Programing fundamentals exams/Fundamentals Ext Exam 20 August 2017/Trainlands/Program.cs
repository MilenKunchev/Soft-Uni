using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            var trains = new Dictionary<string, Dictionary<string, int>>();

            string inputData = string.Empty;

            while ((inputData = Console.ReadLine()) != "It's Training Men!")
            {
                if (inputData.Contains(" : "))
                {
                    AddNewTrainOrWagon(trains, inputData);
                }
                else if (inputData.Contains(" = "))
                {
                    CopyTrain(trains, inputData);
                }
                else
                {
                    AddWagonsToAtherTrain(trains, inputData);
                }
            }

            var wagonsPower = new Dictionary<string, int>();

            foreach (var train in trains)
            {
                wagonsPower[train.Key] = train.Value.Values.Sum();
            }
            // use this dictionary to order by wagon power sum, trains dictionary
            wagonsPower = wagonsPower.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var train in trains.OrderByDescending(x => wagonsPower[x.Key]).ThenBy(y => y.Value.Count))
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var wagon in train.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }

        private static void AddWagonsToAtherTrain(Dictionary<string, Dictionary<string, int>> trains, string inputData)
        {
            string[] inputDataTokens = inputData.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => x.Trim())
                 .ToArray();

            // {trainName} = {otherTrainName}
            string trainName = inputDataTokens[0];
            string otherTrainName = inputDataTokens[1];

            var tempDict = trains[otherTrainName].ToDictionary(x => x.Key, x => x.Value);

            if (!trains.ContainsKey(trainName))
            {
                trains[trainName] = tempDict;
            }
            else
            {
                foreach (KeyValuePair<string, int> item in trains[otherTrainName])
                {
                    trains[trainName][item.Key] = item.Value; // If wagon name exist in trainName -> posible problem
                }
            }

            trains.Remove(otherTrainName);
        }

        private static void CopyTrain(Dictionary<string, Dictionary<string, int>> trains, string inputData)
        {
            string[] inputDataTokens = inputData.Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            // {trainName} = {otherTrainName}
            string trainName = inputDataTokens[0];
            string otherTrainName = inputDataTokens[1];

            trains[trainName] = new Dictionary<string, int>();
            var tempDict = trains[otherTrainName].ToDictionary(x => x.Key, x => x.Value);
            trains[trainName] = tempDict;

        }

        static void AddNewTrainOrWagon(Dictionary<string, Dictionary<string, int>> trains, string inputData)
        {
            string[] inputDataTokens = inputData.Split(new[] { "->", ":" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            //{trainName} -> {wagonName} : {wagonPower}
            string trainName = inputDataTokens[0];
            string wagonName = inputDataTokens[1];
            int wagonPower = int.Parse(inputDataTokens[2]);

            if (!trains.ContainsKey(trainName))
            {
                trains[trainName] = new Dictionary<string, int>()
                {
                    { wagonName,wagonPower}
                };
            }
            else
            {
                trains[trainName][wagonName] = wagonPower;
            }
        }
    }
}
