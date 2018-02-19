using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snowmen

{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (elements.Count > 1)
            {
                HashSet<int> losers = new HashSet<int>();

                Traverse(losers, elements);

                elements = RemoveLosers(losers, elements);

            }
        }

        private static List<int> RemoveLosers(HashSet<int> losers, List<int> elements)
        {
            foreach (var loser in losers)
            {
                elements[loser] = -1;
            }
            return elements = elements.Where(n => n != -1).ToList();
        }

        private static void Traverse(HashSet<int> losers, List<int> elements)
        {

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements.Count - losers.Count == 1)
                    break;

                int attackerIndex = i;
                int targetIndex = GetTargetIndex(attackerIndex, elements);

                int difference = Math.Abs(attackerIndex - targetIndex);

                if (losers.Contains(attackerIndex)) continue;

                if (difference == 0)
                {
                    Console.WriteLine($"{attackerIndex} performed harakiri");
                    losers.Add(attackerIndex);
                }
                else if (difference % 2 == 0)
                {
                    Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                    losers.Add(targetIndex);
                }
                else if (difference % 2 != 0)
                {
                    Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                    losers.Add(attackerIndex);
                }
            }
        }

        private static int GetTargetIndex(int attackerIndex, List<int> elements)
        {
            int targetIndex = elements[attackerIndex];

            if (targetIndex >= elements.Count)
            {
                return targetIndex % elements.Count;
            }
            else
            {
                return targetIndex;
            }

        }
    }
}
