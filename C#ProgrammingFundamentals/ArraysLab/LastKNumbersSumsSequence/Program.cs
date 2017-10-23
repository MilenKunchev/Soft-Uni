using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            var seq = new long[n];
            seq[0] = 1;
            for (long i = 1; i < n; i++) //loop for array of sums
            {
                long firstPosition = i - k;
                if (firstPosition < 0)
                {
                    firstPosition = 0;
                }

                for (long j = firstPosition; j < i; j++)
                {
                    seq[i] = seq[i] + seq[j];

                }

            }
            Console.WriteLine(String.Join(" ", seq));
        }
    }
}
