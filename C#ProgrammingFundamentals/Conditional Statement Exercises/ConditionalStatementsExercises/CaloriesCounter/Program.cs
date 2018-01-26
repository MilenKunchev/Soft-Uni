using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredientsCount = int.Parse(Console.ReadLine());
            int totalCalories = 0;

            for (int i = 0; i < ingredientsCount; i++)
            {
                string input = Console.ReadLine();
                string ingredient = input.ToLower();

                if (ingredient == "cheese") totalCalories += 500;
                if (ingredient == "tomato sauce") totalCalories += 150;
                if (ingredient == "salami") totalCalories += 600;
                if (ingredient == "pepper") totalCalories += 50;
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
