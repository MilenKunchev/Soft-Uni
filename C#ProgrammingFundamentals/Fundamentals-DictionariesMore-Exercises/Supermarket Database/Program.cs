using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> productInfo = ReadInput();

            Dictionary<string, Dictionary<decimal, int>> productsCatalogue = new
                Dictionary<string, Dictionary<decimal, int>>();
            while (productInfo[0] != "stocked")
            {
                AddproductsInfoToCatalogue(productInfo, productsCatalogue);
                productInfo = ReadInput();
            }
            PrintResult(productsCatalogue);
        }

        private static void PrintResult(Dictionary<string, Dictionary<decimal, int>> productsCatalogue)
        {
            decimal grandTotal = 0m;
            foreach (var product in productsCatalogue)
            {
                foreach (var priceAndQuantity in product.Value)
                {
                    Console.WriteLine($"{product.Key}: ${priceAndQuantity.Key:f2} * {priceAndQuantity.Value}" +
                        $" = ${priceAndQuantity.Key * priceAndQuantity.Value:f2}");
                    grandTotal += (priceAndQuantity.Key * priceAndQuantity.Value);
                }
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }

        private static void AddproductsInfoToCatalogue(List<string> productInfo,
            Dictionary<string, Dictionary<decimal, int>> productsCatalogue)
        {
            string productName = productInfo[0];
            decimal productPrice = decimal.Parse(productInfo[1]);
            int productQuantity = int.Parse(productInfo[2]);

            if (!productsCatalogue.ContainsKey(productName))
            {
                productsCatalogue[productName] = new Dictionary<decimal, int>();
                productsCatalogue[productName][productPrice] = productQuantity;
            }
            else
            {
                int oldquantity = productsCatalogue[productName].Values.Last();
                productsCatalogue.Remove(productName);
                productsCatalogue[productName] = new Dictionary<decimal, int>();
                productsCatalogue[productName][productPrice] = (productQuantity + oldquantity);
            }
        }

        private static List<string> ReadInput()
        {
            var productsInfo = Console.ReadLine().Split().ToList();
            return productsInfo;
        }
    }

}
