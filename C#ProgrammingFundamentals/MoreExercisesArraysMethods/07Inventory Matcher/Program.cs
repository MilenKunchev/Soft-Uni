using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesOfTheProducts = Console.ReadLine().Split(' ').ToArray();
            long[] quantitiesOfTheProducts = Console.ReadLine().Split(' ').
                Select(long.Parse).ToArray();
            decimal[] pricesOfTheProducts = Console.ReadLine().Split(' ').
                Select(decimal.Parse).ToArray();

            PrintInfoForProducts(namesOfTheProducts, quantitiesOfTheProducts, pricesOfTheProducts);

        }

            // make conflict for exercise , make again.

        private static void PrintInfoForProducts(string[] namesOfTheProducts, long[] quantitiesOfTheProducts, decimal[] pricesOfTheProducts)
        {
            
            while (true)
            {
                string productName = Console.ReadLine();
		// Check for "done" and stop program if true.
                if (productName == "done")
                {
                    break;
                }
                int indexOfProduct = Array.IndexOf(namesOfTheProducts, productName);
                Console.WriteLine($"{productName} costs: {pricesOfTheProducts[indexOfProduct]}" +
                    $"; Available quantity: {quantitiesOfTheProducts[indexOfProduct]}");
            }
        }
    }
}
