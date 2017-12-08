using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            List<string> randomized = new List<string>();
            Random rnd = new Random();

            foreach (var word in input)
            {
                randomized.Insert(rnd.Next(0, randomized.Count+1), word);
            }
            foreach (var word in randomized)
            {
                Console.Write($"{word}{Environment.NewLine}");
            }

        }
    }
}
