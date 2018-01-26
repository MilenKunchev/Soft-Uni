using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {

            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            int round = 0;

            while (true)
            {
                goshoHealth -= peshoDamage;
                
                round++;

                if (goshoHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }

                if (round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }                              

                peshoHealth -= goshoDamage;                
                round++;

                if (peshoHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                if (round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
                
                
            }
        }
    }
}
