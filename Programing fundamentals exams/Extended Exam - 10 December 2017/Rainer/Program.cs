using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read sequence of integers.
            var gameField = Console.ReadLine().Split().Select(int.Parse).ToList();

            // This is Donald posotion.
            int donaldPosition = gameField.Last();
            //  Steps that Donald made.
            int stepsCounter = 0;

            // Remove Donald position index from sequence.
            // This is game fiels.
            gameField.RemoveAt(gameField.Count - 1);

            // This array keep original values of game field.
            int[] originalValues = gameField.Select(x => x).ToArray();

            while (true)
            {
                // Decrease all of the integers.
                gameField = gameField.Select(x => x - 1).ToList();

                // Check if Donald is wet.
                if (gameField[donaldPosition] == 0)
                {
                    // Game over.
                    break;
                }

                // If Donald is not wet.
                else
                {
                    // Check for 0 in game field.
                    for (int i = 0; i < gameField.Count; i++)
                    {
                        // If have 0 in game field.
                        if (gameField[i] == 0)
                        {
                            // Replace 0 with original value.
                            gameField[i] = originalValues[i];
                        }
                    }
                }

                // Read new Donald position from console.
                donaldPosition = int.Parse(Console.ReadLine());
                stepsCounter++;
            }

            //Print game field. 
            Console.WriteLine(string.Join(" ", gameField));
            //Print count of steps Donald made.
            Console.WriteLine(stepsCounter);

        }
    }
}
