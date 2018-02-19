using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            long hornetSumPower = hornets.Sum(x => x);

            // Attack
            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornetSumPower > beehives[i])
                {
                    beehives[i] = 0;
                }
                else
                {
                    hornets.RemoveAt(0);
                    beehives[i] -= hornetSumPower;
                    hornetSumPower = hornets.Sum(x => x);

                    if (hornets.Count == 0)
                    {
                        break;
                    }
                }
            }
            if (beehives.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x != 0)));
            }
            else if (hornets.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", hornets.Where(x => x != 0)));
            }

        }
    }
}
