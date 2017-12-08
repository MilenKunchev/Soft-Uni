using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            do
            {
                factorial = factorial * n;
                n--;
            } while (n > 1);
            Console.WriteLine(factorial);
        }
    }
}
