using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> customersFlights = new Dictionary<string, List<int>>();

            string inputData = string.Empty;

            while ((inputData = Console.ReadLine()) != "I believe I can fly!")
            {
                // Thi is {customerName} {customerFlight1} {customerFlight2} case.
                if (!inputData.Contains(" = "))
                {
                    AddCustomerFlights(customersFlights, inputData);
                }
                // Thi is {customerName} = {customer2Name} case.
                else
                {
                    CopyCustomersFlights(customersFlights, inputData);
                }
            }
            var ordered = customersFlights.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var customer in ordered)
            {
                Console.Write($"#{customer.Key} ::: ");
                Console.WriteLine(string.Join(", ", customer.Value.OrderBy(x => x)));
            }
        }

        private static void CopyCustomersFlights(Dictionary<string, List<int>> customersFlights, string inputData)
        {
            string[] inputDataTokens = inputData.Split(new[] { '=' }).Select(x => x.Trim()).ToArray();
            string newCustomer = inputDataTokens[0];
            string oldCustomer = inputDataTokens[1];

            customersFlights[newCustomer] = new List<int>(customersFlights[oldCustomer]);
        }

        private static void AddCustomerFlights(Dictionary<string, List<int>> customersFlights, string inputData)
        {
            string[] inputDataTokens = inputData.Split().ToArray();
            string customerName = inputDataTokens[0];

            if (!customersFlights.ContainsKey(customerName))
            {
                customersFlights[customerName] = new List<int>();
                AddFlights(customersFlights, inputDataTokens);
            }
            else
            {
                AddFlights(customersFlights, inputDataTokens);
            }


        }

        private static void AddFlights(Dictionary<string, List<int>> customersFlights, string[] inputDataTokens)
        {
            string customerName = inputDataTokens[0];

            for (int i = 1; i < inputDataTokens.Length; i++)
            {
                int flight = int.Parse(inputDataTokens[i]);
                customersFlights[customerName].Add(flight);
            }
        }
    }
}
