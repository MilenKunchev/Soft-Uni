using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrophonTheGrumpyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] priceRatings = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string itemsType = Console.ReadLine();  // cheap or expensive and the same price then entry point value;
            string typeOfPrice = Console.ReadLine(); //positive , newgative or all

            long entryPointValue = priceRatings[entryPoint];
            long sumLeft = 0;
            long sumRight = 0;

            if (priceRatings.Length > 1)
            {
                var leftPart = priceRatings.Take(entryPoint).ToArray();
                var rightPart = priceRatings.Skip(entryPoint + 1).ToArray();

                if (itemsType == "cheap")
                {
                    switch (typeOfPrice)
                    {
                        case "positive":
                            sumLeft = leftPart.Where(x => x < entryPointValue && x >= 0).Sum();
                            sumRight = rightPart.Where(x => x < entryPointValue && x >= 0).Sum();
                            break;

                        case "negative":
                            sumLeft = leftPart.Where(x => x < entryPointValue && x < 0).Sum();
                            sumRight = rightPart.Where(x => x < entryPointValue && x < 0).Sum();
                            break;

                        case "all":
                            sumLeft = leftPart.Where(x => x < entryPointValue).Sum();
                            sumRight = rightPart.Where(x => x < entryPointValue).Sum();
                            break;
                    }
                }

                if (itemsType == "expensive")
                {
                    switch (typeOfPrice)
                    {
                        case "positive":
                            sumLeft = leftPart.Where(x => x >= entryPointValue && x >= 0).Sum();
                            sumRight = rightPart.Where(x => x >= entryPointValue && x >= 0).Sum();
                            break;

                        case "negative":
                            sumLeft = leftPart.Where(x => x >= entryPointValue && x < 0).Sum();
                            sumRight = rightPart.Where(x => x >= entryPointValue && x < 0).Sum();
                            break;

                        case "all":
                            sumLeft = leftPart.Where(x => x >= entryPointValue).Sum();
                            sumRight = rightPart.Where(x => x >= entryPointValue).Sum();
                            break;
                    }
                }
            }
            if (sumRight > sumLeft)
            {
                Console.WriteLine($"Right - {sumRight}");
            }
            else
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
        }
    }
}
