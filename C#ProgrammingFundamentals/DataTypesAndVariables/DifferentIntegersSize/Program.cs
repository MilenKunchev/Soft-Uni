using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();

            long number = 0;
            bool isLong = long.TryParse(inputNum, out number);

            if (!isLong)
            {
                Console.WriteLine($"{inputNum} can't fit in any type");
            }

            else
            {

                Console.WriteLine($"{inputNum} can fit in:");

                if (number <= sbyte.MaxValue && number >= sbyte.MinValue)
                {
                    Console.WriteLine("* sbyte");
                }

                if (number <= byte.MaxValue && number >= byte.MinValue)
                {
                    Console.WriteLine("* byte");
                }

                if (number <= short.MaxValue && number >= short.MinValue)
                {
                    Console.WriteLine("* short");
                }

                if (number <= ushort.MaxValue && number >= ushort.MinValue)
                {
                    Console.WriteLine("* ushort");
                }

                if (number <= int.MaxValue && number >= int.MinValue)
                {
                    Console.WriteLine("* int");
                }

                if (number <= uint.MaxValue && number >= uint.MinValue)
                {
                    Console.WriteLine("* uint");
                }

                Console.WriteLine("* long");
            }

            //(sbyte < byte < short < ushort < int < uint < long).

        }
    }
}
