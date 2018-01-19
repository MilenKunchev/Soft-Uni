using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexesOfLadybugs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];

            AddLadybugsTofield(indexesOfLadybugs, field);

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "end")
            {
                string[] tokens = commands.Split().ToArray();
                int ladybugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLength = int.Parse(tokens[2]);

                bool haveBugInField = CheckIsItBugInTHEField(ladybugIndex, field);
                if (haveBugInField)
                {
                    long newIndex = FindNewIndex(ladybugIndex, flyLength, direction, field);

                    if (newIndex == ladybugIndex) ;

                    else if (newIndex >= 0 && newIndex < field.Length)
                    {
                        field[newIndex] = 1;
                        field[ladybugIndex] = 0;
                    }
                    else
                    {
                        field[ladybugIndex] = 0;
                    }

                }
            }
            Console.WriteLine(string.Join(" ", field));
        }

        private static long FindNewIndex(int ladybugIndex, int flyLength, string direction, int[] field)
        {
            long newIndex = 0;

            if (flyLength == 0) return newIndex = ladybugIndex;

            if (direction == "right")
            {
                newIndex = ladybugIndex + flyLength;
            }
            else if (direction == "left")
            {
                newIndex = ladybugIndex - flyLength;
            }
            // new index is in range of the array, and no ather bug there
            while (newIndex >= 0 && newIndex < field.Length && field[newIndex] == 1)
            {
                if (direction == "right") newIndex += flyLength;

                if (direction == "left") newIndex -= flyLength;
            }
            return newIndex;
        }

        private static bool CheckIsItBugInTHEField(int ladybugIndex, int[] field)
        {
            if (ladybugIndex >= 0 && ladybugIndex < field.Length)
            {
                if (field[ladybugIndex] == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static void AddLadybugsTofield(int[] indexesOfLadybugs, int[] field)
        {
            foreach (var index in indexesOfLadybugs)
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }
        }
    }
}
