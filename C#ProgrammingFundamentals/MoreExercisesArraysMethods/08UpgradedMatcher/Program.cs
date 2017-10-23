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

        private static void PrintInfoForProducts(string[] namesOfTheProducts, long[] quantitiesOfTheProducts, decimal[] pricesOfTheProducts)
        {

            while (true)
            {
                string[] order = Console.ReadLine().Split(' ').ToArray();
                string productName = order[0];

                if (productName == "done")
                {
                    break;
                }

                long orderQuantiti = long.Parse(order[1]);
                int indexOfProduct = Array.IndexOf(namesOfTheProducts, productName);

                if (indexOfProduct >= quantitiesOfTheProducts.Length ||
                   orderQuantiti > quantitiesOfTheProducts[indexOfProduct])
                {
                    Console.WriteLine($"We do not have enough {productName}");
                }
                else
                {
                    decimal orederPrice = orderQuantiti * pricesOfTheProducts[indexOfProduct];

                    Console.WriteLine($"{productName} x {orderQuantiti} costs {orederPrice:f2}");
                    quantitiesOfTheProducts[indexOfProduct] -= orderQuantiti;
                }
            }
        }
    }
}
