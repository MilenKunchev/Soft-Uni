using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfNums = Console.ReadLine().Split(' ');

            PrintTriples(arrayOfNums);

        }

        private static void PrintTriples(string[] arrayOfNums)
        {

            bool noTriples = true;
            for (int i = 0; i < arrayOfNums.Length; i++)
            {
                for (int j = i + 1; j < arrayOfNums.Length; j++)
                {
                    int a = int.Parse(arrayOfNums[i]);
                    int b = int.Parse(arrayOfNums[j]);
                    int sum = a + b;
                    foreach (var num in arrayOfNums)
                    {

                        if (sum == int.Parse(num))
                        {
                            Console.WriteLine($"{a} + {b} == {sum}");
                            noTriples = false;
                            break;
                        }
                    }

                }

            }
            if (noTriples)
            {
                Console.WriteLine("No");
            }

        }
    }
}
