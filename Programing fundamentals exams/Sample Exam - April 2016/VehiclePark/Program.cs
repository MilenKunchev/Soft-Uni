using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePark
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read vehicle in array
            var vehicles = Console.ReadLine().Split().Select(x => x = x.ToLower()).ToList();
            //Read requests for vehicles 
            string request = string.Empty;
            int vehicleSold = 0;

            while ((request = Console.ReadLine()) != "End of customers!")
            {
                string[] requestTokens = request.Split().ToArray();
                // Find desired vehicle code 
                string desiredVehicle = requestTokens[0][0].ToString().ToLower() + requestTokens[2];

                // If desired vehicle is not in the list for sale
                if (!vehicles.Contains(desiredVehicle))
                {
                    Console.WriteLine("No");
                }
                // If desired vehicle is in the list for sale
                else
                {
                    // Calculate price for vehicle
                    decimal vehiclePrice = CalculateVehiclePrice(desiredVehicle);
                    Console.WriteLine($"Yes, sold for {vehiclePrice}$");
                    // Remove vehicle from list for sale
                    int indexOfVehicle = vehicles.IndexOf(desiredVehicle);
                    vehicles[indexOfVehicle] = "0";
                    // Sold vehicle counter
                    vehicleSold++;
                }
            }
            Console.Write("Vehicles left: ");
            Console.WriteLine(string.Join(", ", vehicles.Where(x => x != "0")));
            Console.WriteLine($"Vehicles sold: {vehicleSold}");
        }

        private static decimal CalculateVehiclePrice(string desiredVehicle)
        {
            int firstPriceElement = desiredVehicle[0];
            int secondPriceElement = int.Parse(desiredVehicle.Remove(0, 1));
            decimal totalPrice = (decimal)firstPriceElement * secondPriceElement;
            return totalPrice;
        }
    }
}
