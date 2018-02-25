using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine()); //0.00…1,000,000,000.00
            int numberOfGuests = int.Parse(Console.ReadLine()); //0…1,000,000,000
            decimal priceForBananasForOne = decimal.Parse(Console.ReadLine()); //0.00…1,000.00
            decimal priceForEggsForOne = decimal.Parse(Console.ReadLine());
            decimal priceForBerriesForKillo = decimal.Parse(Console.ReadLine());

            int numberOfPortions = CalculateNumberOfPortions(numberOfGuests);

            decimal bananasPrice = (priceForBananasForOne * 2m) * numberOfPortions;
            decimal eggsPrice = (priceForEggsForOne * 4m) * numberOfPortions;
            decimal berriesPrice = (priceForBerriesForKillo * 0.2m) * numberOfPortions;

            decimal totalPrice = bananasPrice + eggsPrice + berriesPrice;

            if (totalPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            if (totalPrice > cash)
            {
                decimal neededMoney = totalPrice - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
            }
        }

        static int CalculateNumberOfPortions(int numberOfGuests)
        {
            int numberOfPortuons = 0;

            if (numberOfGuests % 6 == 0)
            {
                numberOfPortuons = numberOfGuests / 6;
                return numberOfPortuons;
            }
            else
            {
                numberOfPortuons = (numberOfGuests / 6) + 1;
                return numberOfPortuons;
            }
        }
    }
}
