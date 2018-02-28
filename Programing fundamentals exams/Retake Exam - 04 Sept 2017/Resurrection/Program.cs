using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                long totalLength = long.Parse(Console.ReadLine()); // int [-231, 231].
                decimal totalWidth = decimal.Parse(Console.ReadLine());// floating-point number in range [-231, 231] 0.20 digits
                int wingLength = int.Parse(Console.ReadLine()); // int [-231, 231 – 1].

                //totalYears = { totalLength} ^ 2 * ({ totalWidth}+2 * { wingLength})
                decimal totalLengthPow = (decimal)totalLength * (totalLength);
                decimal sumWidthWindLength = (decimal)totalWidth + 2m * wingLength;
                decimal totalYears = totalLengthPow * sumWidthWindLength;

                Console.WriteLine(totalYears);
            }

        }
    }
}
