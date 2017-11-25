using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            int initialHealth = int.Parse(Console.ReadLine());
            int healthLeft = initialHealth;
            string virusName = Console.ReadLine();

            List<string> defeatedViruses = new List<string>();

            while (virusName != "end")
            {
                int virusStrength = CalculateVirusStrength(virusName);
                int timeToDefeat = CalculateTimeToDefeat(virusStrength, virusName, defeatedViruses);

                healthLeft -= timeToDefeat;

                if (healthLeft > 0)
                {
                    int minutes = timeToDefeat / 60;
                    int seconds = timeToDefeat % 60;
                    Console.WriteLine($"Virus {virusName}: {virusStrength} => {timeToDefeat} seconds");
                    Console.WriteLine($"{virusName} defeated in {minutes}m {seconds}s.");
                    Console.WriteLine($"Remaining health: {healthLeft}");

                    healthLeft = CalculateHealthRecovery(healthLeft, initialHealth);
                }
                else
                {
                    Console.WriteLine($"Virus {virusName}: {virusStrength} => {timeToDefeat} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                virusName = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {healthLeft}");
        }

        private static int CalculateHealthRecovery(int healthLeft, int initialHealth)
        {
            healthLeft += (int)(healthLeft * 0.2);
            if (healthLeft > initialHealth)
            {
                healthLeft = initialHealth;
            }
            return healthLeft;
        }

        private static int CalculateTimeToDefeat(int virusStrength, string virusName, List<string> defeatedViruses)
        {
            int timeToDefeat = virusStrength * virusName.Length;
            if (defeatedViruses.Contains(virusName))
            {
                timeToDefeat /= 3;
            }
            else
            {
                defeatedViruses.Add(virusName);
            }
            return timeToDefeat;
        }

        private static int CalculateVirusStrength(string virusName)
        {
            int virusStrength = 0;
            foreach (var character in virusName)
            {
                virusStrength += character;
            }
            virusStrength /= 3;

            return virusStrength;
        }
    }
}
