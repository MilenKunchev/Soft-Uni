using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ').ToArray();
            int searchedLength = int.Parse(Console.ReadLine());

            bool ingredientsToAdd = false;
            int countOfIngredients = 0;
            var usedIngredientList = new List<string>();

            for (int i = 0; i < ingredients.Length; i++)
            {
                ingredientsToAdd = GetMatchIngIngredient(ingredients[i], searchedLength);
                if (countOfIngredients < 10 && ingredientsToAdd)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    countOfIngredients++;
                    usedIngredientList.Add(ingredients[i]);
                }
                else if (countOfIngredients == 10)
                {
                    Console.WriteLine($"Made pizza with total of {countOfIngredients} ingredients.");
                    Console.WriteLine($"The ingredients are: {string.Join(", ", usedIngredientList)}.");
                    break;
                }
            }
            if (countOfIngredients < 10)
            {
                Console.WriteLine($"Made pizza with total of {countOfIngredients} ingredients.");
                Console.WriteLine($"The ingredients are: {string.Join(", ", usedIngredientList)}.");
            }
        }

        private static bool GetMatchIngIngredient(string ingredient, int searchedLength)
        {
            if (ingredient.Length == searchedLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
