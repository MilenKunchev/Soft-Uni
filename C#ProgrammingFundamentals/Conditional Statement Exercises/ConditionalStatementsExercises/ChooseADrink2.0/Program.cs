using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            decimal totalPrice = 0m;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = count * 0.70m;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
                    break;

                case "Businessman":
                    totalPrice = count * 1m;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
                    break;

                case "Businesswoman":
                    totalPrice = count * 1m;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
                    break;

                case "SoftUni Student":
                    totalPrice = count * 1.70m;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
                    break;

                default:
                    totalPrice = count * 1.20m;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
                    break;

            }

        }
    }
}
