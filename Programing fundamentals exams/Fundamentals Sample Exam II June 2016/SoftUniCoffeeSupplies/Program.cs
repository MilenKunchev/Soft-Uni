using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            var personAndCoffeeType = new Dictionary<string, string>();
            var coffeeTypeAndQuantity = new Dictionary<string, int>();

            string[] delimiters = Console.ReadLine().Split().ToArray();

            string personeNameDelimiter = delimiters[0];
            string coffeeTypeDelimiter = delimiters[1];

            string inputData = string.Empty;

            while ((inputData = Console.ReadLine()) != "end of info")
            {
                if (inputData.Contains(personeNameDelimiter))// IPerson name - coffee type info
                {
                    AddPersonAndCoffeeType(personAndCoffeeType, personeNameDelimiter, inputData);
                }
                if (inputData.Contains(coffeeTypeDelimiter))// Coffee type - quantity info
                {
                    AddCoffeeTypeAndQuantity(coffeeTypeAndQuantity, coffeeTypeDelimiter, inputData);
                }
            }
            // Check for coffee in person-coffeeType dict ,missing in coffee - quantity dict.
            foreach (var coffeeType in personAndCoffeeType)
            {
                if (!coffeeTypeAndQuantity.ContainsKey(coffeeType.Value))
                {
                    Console.WriteLine($"Out of {coffeeType.Value}");
                }
            }
            // Drinked coffees
            string drinkData = string.Empty;
            while ((drinkData = Console.ReadLine()) != "end of week")
            {
                DrinkCoffee(personAndCoffeeType, coffeeTypeAndQuantity, drinkData);
            }

            // Print coffee left 
            Console.WriteLine("Coffee Left:");
            foreach (var coffeeType in coffeeTypeAndQuantity.Where(x => x.Value > 0).OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{coffeeType.Key} {coffeeType.Value}");
            }
            Console.WriteLine("For:");
            foreach (var person in personAndCoffeeType.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (coffeeTypeAndQuantity.ContainsKey(person.Value) && coffeeTypeAndQuantity[person.Value] > 0)
                {
                    Console.WriteLine($"{person.Key} {person.Value}");
                }
            }
        }

        static void DrinkCoffee(Dictionary<string, string> personAndCoffeeType
           , Dictionary<string, int> coffeeTypeAndQuantity, string drinkData)
        {
            string[] drinkDataTokens = drinkData.Split().ToArray();
            string person = drinkDataTokens[0];
            int coffeeDrinksCount = int.Parse(drinkDataTokens[1]);
            string typeCoffeeForThisPerson = personAndCoffeeType[person];

            if (!coffeeTypeAndQuantity.ContainsKey(typeCoffeeForThisPerson) ||
                coffeeTypeAndQuantity[typeCoffeeForThisPerson] == 0)
            {
                Console.WriteLine($"Out of {typeCoffeeForThisPerson}");
            }
            else
            {
                coffeeTypeAndQuantity[typeCoffeeForThisPerson] -= coffeeDrinksCount;
                if (coffeeTypeAndQuantity[typeCoffeeForThisPerson] <= 0)
                {
                    Console.WriteLine($"Out of {typeCoffeeForThisPerson}");
                }
            }
        }

        static void AddCoffeeTypeAndQuantity(Dictionary<string, int> coffeeTypeAndQuantity, string coffeeTypeDelimiter, string inputInfo)
        {
            string[] inputInfoTokens = inputInfo
                                    .Split(new[] { coffeeTypeDelimiter }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            string coffeeType = inputInfoTokens[0];
            int coffeeQuantity = int.Parse(inputInfoTokens[1]);

            if (!coffeeTypeAndQuantity.ContainsKey(coffeeType))
            {
                coffeeTypeAndQuantity[coffeeType] = coffeeQuantity;
            }
            else
            {
                coffeeTypeAndQuantity[coffeeType] += coffeeQuantity;
            }
        }

        static void AddPersonAndCoffeeType(Dictionary<string, string> personAndCoffeeType, string personeNameDelimiter, string inputInfo)
        {
            string[] inputInfoTokens = inputInfo
                                    .Split(new[] { personeNameDelimiter }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            string personName = inputInfoTokens[0];
            string coffeeType = inputInfoTokens[1];
            personAndCoffeeType[personName] = coffeeType;
        }
    }
}
