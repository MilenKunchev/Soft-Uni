using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int stepsCount = 0;
            int stepIndex = 0;

            for (int i = stepIndex; i < sequence.Length; i++)
            {
                int stepValue = sequence[i];

                stepsCount++;

                if (stepValue != 0)
                {
                    stepIndex = i;
                    sequence[i] = 0;
                    i = stepValue;
                    continue;
                }
            }
            Console.WriteLine(stepsCount);
        }
    }
}
