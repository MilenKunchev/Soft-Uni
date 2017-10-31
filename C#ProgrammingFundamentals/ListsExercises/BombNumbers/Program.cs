using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] bombAndPowe = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int bomb = bombAndPowe[0];
            int power = bombAndPowe[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int bombPosition = i;
                    int counter = 0;
                    while (counter != power + 1 && (bombPosition) < numbers.Count) //remove left lements
                    {
                        numbers.RemoveAt(bombPosition);
                        counter++;
                    }
                    counter = 0;
                    while (counter != power && (bombPosition - (counter + 1)) >= 0) //remove left lements
                    {
                        numbers.RemoveAt(bombPosition - (counter + 1));
                        counter++;
                    }

                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
