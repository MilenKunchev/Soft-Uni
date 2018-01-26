using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            decimal studioTotalPrice = 0m;
            decimal doubleTotalPrice = 0m;
            decimal suiteTotalPrice = 0m;

            decimal discount = 0m;

            switch (month)
            {
                case "May":
                    if (nightsCount > 7)
                    {
                        discount = 50m * nightsCount * 0.05m;
                        studioTotalPrice = 50m * nightsCount - discount;
                        doubleTotalPrice = 65m * nightsCount;
                        suiteTotalPrice = 75m * nightsCount;
                    }
                    else
                    {
                        studioTotalPrice = 50m * nightsCount;
                        doubleTotalPrice = 65m * nightsCount;
                        suiteTotalPrice = 75m * nightsCount;
                    }
                    break;

                case "October":
                    if (nightsCount > 7)
                    {
                        discount = 50m - 50m * 0.05m;
                        studioTotalPrice = discount * (nightsCount - 1);
                        doubleTotalPrice = 65m * nightsCount;
                        suiteTotalPrice = 75m * nightsCount;
                    }
                    else
                    {
                        studioTotalPrice = 50m * nightsCount;
                        doubleTotalPrice = 65m * nightsCount;
                        suiteTotalPrice = 75m * nightsCount;
                    }
                    break;

                case "June":
                    if (nightsCount > 14)
                    {
                        discount = 72m * 0.1m * nightsCount;
                        studioTotalPrice = 60m * nightsCount;
                        doubleTotalPrice = 72m * nightsCount - discount;
                        suiteTotalPrice = 82m * nightsCount;
                    }
                    else
                    {
                        studioTotalPrice = 60 * nightsCount;
                        doubleTotalPrice = 72 * nightsCount;
                        suiteTotalPrice = 82 * nightsCount;
                    }

                    break;

                case "September":

                    if (nightsCount > 14)
                    {
                        discount = 72m * 0.1m * nightsCount;
                        studioTotalPrice = 60m * (nightsCount - 1);
                        doubleTotalPrice = 72m * nightsCount - discount;
                        suiteTotalPrice = 82m * nightsCount;
                    }
                    else if (nightsCount > 7 && nightsCount <= 14)
                    {
                        studioTotalPrice = 60m * (nightsCount - 1);
                        doubleTotalPrice = 72m * nightsCount;
                        suiteTotalPrice = 82m * nightsCount;
                    }
                    else
                    {
                        studioTotalPrice = 60 * nightsCount;
                        doubleTotalPrice = 72 * nightsCount;
                        suiteTotalPrice = 82 * nightsCount;
                    }


                    break;

                case "July":
                case "August":
                case "December":
                    if (nightsCount > 14)
                    {
                        discount = 89 * nightsCount * 0.15m;
                        studioTotalPrice = 68 * nightsCount;
                        doubleTotalPrice = 77 * nightsCount;
                        suiteTotalPrice = 89 * nightsCount - discount;
                    }
                    else
                    {
                        studioTotalPrice = 68 * nightsCount;
                        doubleTotalPrice = 77 * nightsCount;
                        suiteTotalPrice = 89 * nightsCount;
                    }
                    break;
            }
            Console.WriteLine($"Studio: {studioTotalPrice:f2} lv.");
            Console.WriteLine($"Double: {doubleTotalPrice:f2} lv.");
            Console.WriteLine($"Suite: {suiteTotalPrice:f2} lv.");
        }
    }
}
