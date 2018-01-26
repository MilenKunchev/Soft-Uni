using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            decimal packagePrice = 0;
            decimal discount = 0m;
            decimal hallPrice = 0m;
            string hallName = string.Empty;

            switch (package)
            {
                case "Normal":
                    packagePrice = 500;
                    discount = 0.05m;
                    break;

                case "Gold":
                    packagePrice = 750;
                    discount = 0.1m;
                    break;

                case "Platinum":
                    packagePrice = 1000;
                    discount = 0.15m;
                    break;
            }

            if (groupSize <= 50 && groupSize > 0)
            {
                hallPrice = 2500;
                hallName = "Small Hall";
                decimal totalPrice = CalculateTotalPrice(hallPrice, packagePrice, discount);
                decimal pricePerPerson = totalPrice / groupSize;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";
                decimal totalPrice = CalculateTotalPrice(hallPrice, packagePrice, discount);
                decimal pricePerPerson = totalPrice / groupSize;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";
                decimal totalPrice = CalculateTotalPrice(hallPrice, packagePrice, discount);
                decimal pricePerPerson = totalPrice / groupSize;

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }

            else
            {
                Console.WriteLine($"We do not have an appropriate hall.");
            }





        }

        private static decimal CalculateTotalPrice(decimal hallPrice, decimal packagePrice, decimal discount)
        {
            decimal priceSum = hallPrice + packagePrice;
            decimal totalPrice = priceSum - (priceSum * discount);
            return totalPrice;
        }
    }
}
