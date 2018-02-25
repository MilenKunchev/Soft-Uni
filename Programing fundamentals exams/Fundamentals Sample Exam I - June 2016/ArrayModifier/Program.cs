using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();

            string[] commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "swap":
                        DoSwap(array, commands);
                        break;

                    case "multiply":
                        DoMultiply(array, commands);
                        break;

                    case "decrease":
                        DoDecrease(ref array, commands);
                        break;
                }
                commands = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(", ", array));
        }

        static void DoDecrease(ref long[] array, string[] commands)
        {
            array = array.Select(x => x = x - 1).ToArray();
        }

        static void DoMultiply(long[] array, string[] commands)
        {
            int firsIndex = int.Parse(commands[1]);
            int secondIndex = int.Parse(commands[2]);

            long firstElement = array[firsIndex];
            long secondElement = array[secondIndex];
            array[firsIndex] = firstElement * secondElement;
        }

        static void DoSwap(long[] array, string[] commands)
        {
            int firsIndex = int.Parse(commands[1]);
            int secondIndex = int.Parse(commands[2]);

            long tempForfirsIndex = array[firsIndex];
            array[firsIndex] = array[secondIndex];
            array[secondIndex] = tempForfirsIndex;
        }
    }
}
