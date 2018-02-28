using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startPosition = int.Parse(Console.ReadLine());

            int damage = 1;
            int currentPosition = startPosition;

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "Supernova")
            {
                string[] commandsTokens = commands.Split().ToArray();
                string direction = commandsTokens[0];
                int stepsCount = int.Parse(commandsTokens[1]);

                int directionElement = 1; // right direction
                if (direction == "left")
                {
                    directionElement = -1;
                }

                currentPosition = Travel(sequence, ref damage, currentPosition, directionElement, stepsCount);
            }
            Console.WriteLine(string.Join(" ", sequence));
        }

        static int Travel(int[] sequence, ref int damage, int currentPosition, int directionElement, int stepsCount)
        {
            int currentIndex = currentPosition + directionElement;// 1 for right or - 1 for left
            int currentStepsCount = 0;

            while (currentStepsCount != stepsCount)
            {
                if (currentIndex < 0)
                {
                    currentIndex = sequence.Length - 1;
                    damage++;
                }
                if (currentIndex > sequence.Length - 1)
                {
                    currentIndex = 0;
                    damage++;
                }
                if (currentIndex < sequence.Length && currentIndex >= 0)
                {
                    sequence[currentIndex] -= damage;
                    currentStepsCount++;
                    currentIndex += directionElement;
                }
            }
            
            // - directionelement --> last while end with direction for one more step line 59.
            return currentIndex - directionElement; 
        }
    }
}
