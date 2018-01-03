using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomCharacters = Console.ReadLine();
            string pattern = Console.ReadLine();

            int firstIndex = randomCharacters.IndexOf(pattern);
            int secondIndex = randomCharacters.LastIndexOf(pattern);

            while (firstIndex != secondIndex && firstIndex != -1 && secondIndex >= pattern.Length + firstIndex)
            {
                randomCharacters = randomCharacters.Remove(secondIndex, pattern.Length);
                randomCharacters = randomCharacters.Remove(firstIndex, pattern.Length);

                Console.WriteLine("Shaked it.");

                int indexOfPatternElementToRemove = pattern.Length / 2;

                if (indexOfPatternElementToRemove >= 1)
                {
                    pattern = pattern.Remove(indexOfPatternElementToRemove, 1);
                }
                else
                {
                    break;
                }
                firstIndex = randomCharacters.IndexOf(pattern);
                secondIndex = randomCharacters.LastIndexOf(pattern);

            }
            Console.WriteLine("No shake.");
            Console.WriteLine(randomCharacters);
        }
    }
}
