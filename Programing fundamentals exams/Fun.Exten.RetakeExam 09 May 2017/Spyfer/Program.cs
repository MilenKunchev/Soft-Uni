using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool checkAgain = true;

            while (sequence.Count > 1 && checkAgain)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    checkAgain = false;
                    int sum = CalculateSum(sequence, i);
                    int currentElement = sequence[i];
                    if (sum == currentElement)
                    {
                        if ((i + 1) < sequence.Count)
                        {
                            sequence.RemoveAt(i + 1);
                        }
                        if ((i - 1) > -1)
                        {
                            sequence.RemoveAt(i - 1);
                        }
                        checkAgain = true;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", sequence));
        }

        static int CalculateSum(List<int> sequence, int i)
        {
            if (i == 0)
            {
                return sequence[i + 1];
            }
            if (i == sequence.Count - 1)
            {
                return sequence[i - 1];
            }

            return sequence[i - 1] + sequence[i + 1];
        }
    }
}
