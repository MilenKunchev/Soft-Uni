using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> removed = new List<int>();
            int lastRemoved = 0;

            while (distances.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    lastRemoved = distances[0];
                    removed.Add(distances[0]);
                    distances[0] = distances[distances.Count - 1];

                    ChangeElementsValue(distances, lastRemoved);
                }
                if (index > distances.Count - 1)
                {
                    lastRemoved = distances[distances.Count - 1];
                    removed.Add(distances[distances.Count - 1]);
                    distances.RemoveAt(distances.Count - 1);

                    ChangeElementsValue(distances, lastRemoved);
                    distances.Add(distances[0]);
                }
                if (index >= 0 && index < distances.Count)
                {
                    removed.Add(distances[index]);
                    distances.RemoveAt(index);

                    lastRemoved = removed.Last();
                    ChangeElementsValue(distances, lastRemoved);
                }
            }

            int sumRemovedElements = 0;
            foreach (var element in removed)
            {
                sumRemovedElements += element;
            }
            Console.WriteLine(sumRemovedElements);
        }

        private static void ChangeElementsValue(List<int> distances, int lastRemoved)
        {
            for (int i = 0; i < distances.Count; i++)
            {

                if (distances[i] <= lastRemoved)
                {
                    distances[i] += lastRemoved;
                }
                else
                {
                    distances[i] -= lastRemoved;
                }
            }
        }
    }
}
