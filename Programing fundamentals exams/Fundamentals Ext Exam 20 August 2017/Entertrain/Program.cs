using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int locomotivePower = int.Parse(Console.ReadLine());

            List<int> wagons = new List<int>();

            while (true)
            {
                string inputData = Console.ReadLine();

                if (inputData == "All ofboard!")
                {
                    break;
                }
                else
                {
                    int wagonsWeight = int.Parse(inputData);

                    wagons.Add(wagonsWeight);

                    int wagonsSum = wagons.Sum();

                    if (wagonsSum > locomotivePower)
                    {
                        int average = wagons.Sum() / wagons.Count;

                        RemoveWagon(average, wagons);
                    }
                }
            }

            wagons.Reverse();
            wagons.Add(locomotivePower);

            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void RemoveWagon(int average, List<int> wagons)
        {
            int wagonIndex = 0;
            int currentDifference = int.MaxValue;

            for (int i = 0; i < wagons.Count; i++)
            {
                int difference = Math.Abs(average - wagons[i]);

                if (difference < currentDifference)
                {
                    currentDifference = difference;
                    wagonIndex = i;
                }
            }

            wagons.RemoveAt(wagonIndex);
        }
    }
}
