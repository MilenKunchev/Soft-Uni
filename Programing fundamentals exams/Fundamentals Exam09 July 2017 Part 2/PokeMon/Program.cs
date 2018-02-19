using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int pokedTargetsCount = 0;
            double nHalfValue = n * 0.5;

            while (!(n < m))
            {
                n -= m;
                pokedTargetsCount++;

                if (n == nHalfValue && y != 0)
                {
                    n /= y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(pokedTargetsCount);
        }
    }
}
