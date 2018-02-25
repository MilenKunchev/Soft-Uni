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

            int[] initialIndexesOfLadybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] fieldWithLadybugs = new int[fieldSize];

            AddLadybugsToField(initialIndexesOfLadybugs, fieldWithLadybugs);

            // Fligthts
            string flyData = Console.ReadLine();
            while (flyData != "end")
            {
                string[] flyDataTokens = flyData.Split().ToArray();
                long ladybugIndex = long.Parse(flyDataTokens[0]);
                string flyDirections = flyDataTokens[1];
                long flyLength = long.Parse(flyDataTokens[2]);

                if (flyDirections == "right")
                {
                    FlyRight(fieldWithLadybugs, ladybugIndex, flyLength);
                }
                if (flyDirections == "left")
                {
                    FlyLeft(fieldWithLadybugs, ladybugIndex, flyLength);
                }

                flyData = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", fieldWithLadybugs));
        }

        private static void FlyLeft(int[] fieldWithLadybugs, long ladybugIndex, long flyLength)
        {
            bool isLadybugIndexInRange = CheckIsInRange(fieldWithLadybugs, ladybugIndex);
            if (isLadybugIndexInRange && fieldWithLadybugs[ladybugIndex] == 1)
            {
                fieldWithLadybugs[ladybugIndex] = 0; // Ladybug fly away

                long newIndex = ladybugIndex - flyLength;
                bool isNewIndexInRange = CheckIsInRange(fieldWithLadybugs, newIndex);

                if (isNewIndexInRange && fieldWithLadybugs[newIndex] == 0)
                {
                    fieldWithLadybugs[newIndex] = 1;
                }
                else if (isNewIndexInRange && fieldWithLadybugs[newIndex] == 1)
                {
                    while (isNewIndexInRange && fieldWithLadybugs[newIndex] == 1)
                    {
                        newIndex -= flyLength;
                        isNewIndexInRange = CheckIsInRange(fieldWithLadybugs, newIndex);
                    }
                    if (isNewIndexInRange)
                    {
                        fieldWithLadybugs[newIndex] = 1;
                    }
                }

            }
        }

        private static void FlyRight(int[] fieldWithLadybugs, long ladybugIndex, long flyLength)
        {
            bool isLadybugIndexInRange = CheckIsInRange(fieldWithLadybugs, ladybugIndex);
            if (isLadybugIndexInRange && fieldWithLadybugs[ladybugIndex] == 1)
            {
                fieldWithLadybugs[ladybugIndex] = 0; // Ladybug fly away

                long newIndex = ladybugIndex + flyLength;
                bool isNewIndexInRange = CheckIsInRange(fieldWithLadybugs, newIndex);

                if (isNewIndexInRange && fieldWithLadybugs[newIndex] == 0)
                {
                    fieldWithLadybugs[newIndex] = 1;
                }
                else if (isNewIndexInRange && fieldWithLadybugs[newIndex] == 1)
                {
                    while (isNewIndexInRange && fieldWithLadybugs[newIndex] == 1)
                    {
                        newIndex += flyLength;
                        isNewIndexInRange = CheckIsInRange(fieldWithLadybugs, newIndex);
                    }
                    if (isNewIndexInRange)
                    {
                        fieldWithLadybugs[newIndex] = 1;
                    }
                }
            }
        }

        static bool CheckIsInRange(int[] field, int Index)
        {
            if (Index >= 0 && Index < field.Length)
            {
                return true;
            }
            return false;
        }

        static bool CheckIsInRange(int[] field, long Index)
        {
            if (Index >= 0 && Index < field.Length)
            {
                return true;
            }
            return false;
        }

        private static void AddLadybugsToField(int[] initialIndexesOfLadybugs, int[] fieldWithLadybugs)
        {
            for (int i = 0; i < initialIndexesOfLadybugs.Length; i++)
            {
                int indexOfLadybug = initialIndexesOfLadybugs[i];

                if (indexOfLadybug >= 0 && indexOfLadybug < fieldWithLadybugs.Length)
                {
                    fieldWithLadybugs[indexOfLadybug] = 1;
                }
            }
        }
    }
}
