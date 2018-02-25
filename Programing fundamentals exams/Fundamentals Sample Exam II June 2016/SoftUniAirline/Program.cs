using System;

namespace SoftUniAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFlights = int.Parse(Console.ReadLine());
            decimal overallProfit = 0m;
            decimal averageProfit = 0m;

            for (int i = 0; i < numberOfFlights; i++)
            {
                long adultPassengersCount = long.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                long youthPassengersCount = long.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelComsumptionPerHour = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = (adultPassengersCount * adultTicketPrice) + (youthPassengersCount * youthTicketPrice);
                decimal expenses = flightDuration * fuelComsumptionPerHour * fuelPricePerHour;

                decimal profit = income - expenses;
                overallProfit += profit;

                if (profit >= 0)
                {
                    Console.WriteLine($"You are ahead with {profit:f3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:f3}$.");
                }
            }
            averageProfit = overallProfit / numberOfFlights;
            Console.WriteLine($"Overall profit -> {overallProfit:f3}$.");
            Console.WriteLine($"Average profit -> {averageProfit:f3}$.");
        }
    }
}
