using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_NToBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            int n = int.Parse(input[0]);
            string nNumber = input[1];

            BigInteger result = new BigInteger();
            for (int i = nNumber.Length - 1; i >= 0; i--)
            {
                BigInteger digit = new BigInteger(char.GetNumericValue(nNumber[i]));
                int pow = nNumber.Length - (i + 1);
                BigInteger digitResult = BigInteger.Multiply(digit, BigInteger.Pow(n, pow));
                result += digitResult;
            }
            Console.WriteLine(result);
        }
    }
}
