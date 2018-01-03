using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_10toBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            BigInteger n = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            StringBuilder result = new StringBuilder();

            while (number > 0)
            {
                BigInteger remainder = (number % n);
                number /= n;
                result.Append(remainder);
            }

            StringBuilder reversed = new StringBuilder();
            for (int i = result.Length - 1; i >= 0; i--)
            {
                reversed.Append(result[i]);
            }
            Console.WriteLine(reversed);
        }
    }
}
