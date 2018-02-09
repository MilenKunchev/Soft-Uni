using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guestNumber = int.Parse(Console.ReadLine());

            decimal priceForOneBanana = decimal.Parse(Console.ReadLine());
            decimal priceForOneEgg = decimal.Parse(Console.ReadLine());
            decimal priceForKiloBerries = decimal.Parse(Console.ReadLine());

            // Finding number of portions.
            int countPortions = guestNumber / 6;
            if (guestNumber % 6 != 0)
            {
                countPortions++;
            }
            // Price for one portion 
            decimal PriceForOnePortion = priceForOneBanana * 2 + priceForOneEgg * 4 + priceForKiloBerries * 0.2m;

            //Total price 
            decimal totalPrice = PriceForOnePortion * countPortions;

            // Print results 
            if (totalPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                decimal neededMoney = totalPrice - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
            }

        }
    }
}
