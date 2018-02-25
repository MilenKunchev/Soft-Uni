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
            string[] allDemons = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            //                                Deomon name -        health - damage
            var demonBook = new SortedDictionary<string, Dictionary<int, double>>();

            foreach (var demon in allDemons)
            {
                if (!demon.Contains(" "))
                {
                    demonBook[demon] = new Dictionary<int, double>();

                    int demonHealth = FindDemonHealth(demon);
                    double demonDamage = FindDemonDamage(demon);

                    demonBook[demon][demonHealth] = demonDamage;
                }
            }
            foreach (var demon in demonBook)
            {
                foreach (var demonStats in demon.Value)
                {
                    Console.WriteLine($"{demon.Key} - {demonStats.Key} health, {demonStats.Value:f2} damage ");
                }
            }
        }

        private static int FindDemonHealth(string demon)
        {
            string pattern = @"[^0-9+\-*\/.]";
            int health = 0;
            foreach (Match m in Regex.Matches(demon, pattern))
            {
                health += m.Value.ToString()[0];
            }

            return health;
        }

        private static double FindDemonDamage(string demon)
        {
            double damage = 0;
            string pattern = @"[-+]?[0-9]+\.?[0-9]*";
            foreach (Match num in Regex.Matches(demon, pattern))
            {
                damage += double.Parse(num.ToString());
            }

            if (damage != 0)
            {
                foreach (var element in demon)
                {
                    if (element == '*')
                    {
                        damage *= 2;
                    }
                    if (element == '/')
                    {
                        damage /= 2;
                    }
                }
            }
            return damage;

        }
    }
}
