using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveОfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[n + 1];
            bool[] primeCheck = new bool[n + 1];
            var primeNums = new List<int>();
            for (int i = 0; i <= n; i++)
            {
                arrayOfNumbers[i] = i;
                primeCheck[i] = true;
            }
            primeNums = CalculateSieveОfEratosthenes(arrayOfNumbers, primeCheck);
            Console.WriteLine(string.Join(" ", primeNums));
        }

        private static List<int> CalculateSieveОfEratosthenes(int[] arrayOfNumbers, bool[] primeCheck)
        {
            var primeNums = new List<int>();
            primeCheck[0] = false;
            primeCheck[1] = false;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (primeCheck[i])
                {
                    primeNums.Add(arrayOfNumbers[i]);

                    for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                    {
                        if (arrayOfNumbers[j] % i == 0 && primeCheck[j] == true)
                        {
                            primeCheck[j] = false;
                        }
                    }
                }

            }
            return primeNums;
        }
    }
}