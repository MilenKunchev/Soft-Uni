using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = string.Empty;
            int counter = 0;
            while ((ingredient = Console.ReadLine()) != "Bake!")
            {
                counter++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
