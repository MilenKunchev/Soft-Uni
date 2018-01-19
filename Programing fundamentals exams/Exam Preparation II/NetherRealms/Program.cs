using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            List<Demon> demons = new List<Demon>();

            foreach (var demonName in input)
            {
                Demon anyDemon = new Demon();
                // find health
                int health = FindHealth(demonName);
                // find damage
                double damage = FindDamage(demonName);

                anyDemon.Name = demonName;
                anyDemon.Health = health;
                anyDemon.Damage = damage;

                demons.Add(anyDemon);
            }
            foreach (var demon in demons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }

        }

        private static double FindDamage(string demonName)
        {
            double damage = 0;
            // Sum numbers
            string pattern = @"[+]{0,1}[-]{0,1}[0-9]+[\.]*[0-9]+|[+]{0,1}[-]{0,1}[0-9]+";

            bool haveMatch = Regex.IsMatch(demonName, pattern);

            if (haveMatch)
            {
                foreach (Match match in Regex.Matches(demonName, pattern))
                {
                    damage += double.Parse(match.Value);
                }
            }

            // multiplication and division
            pattern = @"\*|\/";

            haveMatch = Regex.IsMatch(demonName, pattern);

            if (haveMatch)
            {
                foreach (Match match in Regex.Matches(demonName, pattern))
                {
                    if (match.Value.ToString() == "*")
                    {
                        damage = damage * 2;
                    }

                    if (match.Value.ToString() == "/")
                    {
                        damage = damage / 2;
                    }
                }
            }

            return damage;
        }

        private static int FindHealth(string demonName)
        {
            int health = 0;

            string pattern = @"[^0-9\/+\-*.]";

            foreach (Match match in Regex.Matches(demonName, pattern))
            {
                health += char.Parse(match.Value);
            }

            return health;
        }

        class Demon
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public double Damage { get; set; }
        }

    }
}
