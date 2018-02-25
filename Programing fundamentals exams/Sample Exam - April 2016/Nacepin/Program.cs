using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nacepin
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceUsStore = double.Parse(Console.ReadLine());
            double boxWeightUsStore = double.Parse(Console.ReadLine()); // 0 - int.max
            double priceUkStore = double.Parse(Console.ReadLine());
            double boxWeightUkStore = double.Parse(Console.ReadLine());
            double priceChinesStore = double.Parse(Console.ReadLine());
            double boxWeightChinesStore = double.Parse(Console.ReadLine());

            // Bg prices
            priceUsStore /= 0.58;
            priceUkStore /= 0.41;
            priceChinesStore *= 0.27;

            double levaPricePerKiloInUsStore = priceUsStore / boxWeightUsStore;
            double levaPricePerKiloInUkStore = priceUkStore / boxWeightUkStore;
            double levaPricePerKiloInChinesStore = priceChinesStore / boxWeightChinesStore;

            SortedDictionary<string, double> stores = new SortedDictionary<string, double>();
            stores["US store"] = levaPricePerKiloInUsStore;
            stores["UK store"] = levaPricePerKiloInUkStore;
            stores["Chinese store"] = levaPricePerKiloInChinesStore;

            var sorted = stores.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"{sorted.First().Key}. {sorted.First().Value:f2} lv/kg");
            Console.WriteLine($"Difference {sorted.Last().Value - sorted.First().Value:f2} lv/kg");


        }
    }
}
