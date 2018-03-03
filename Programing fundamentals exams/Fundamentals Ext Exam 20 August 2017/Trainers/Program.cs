using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, decimal>()
            {
                {"Technical",0m },
                {"Theoretical",0m },
                {"Practical",0m }
            };
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int distanceInMiles = int.Parse(Console.ReadLine());
                double cargoInTons = double.Parse(Console.ReadLine());
                string team = Console.ReadLine();

                long distanceInMeters = (long)distanceInMiles * 1600;
                double cargoInKillograms = cargoInTons * 1000;

                decimal participantEarnedMoney = ((decimal)cargoInKillograms * 1.5m)
                    - (0.7m * distanceInMeters * 2.5m);

                teams[team] += participantEarnedMoney;

            }
            teams = teams.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            string teamName = teams.First().Key;
            decimal totalEarnedTeamMoney = teams.First().Value;

            Console.WriteLine($"The {teamName} Trainers win with ${totalEarnedTeamMoney:f3}.");
        }
    }
}
