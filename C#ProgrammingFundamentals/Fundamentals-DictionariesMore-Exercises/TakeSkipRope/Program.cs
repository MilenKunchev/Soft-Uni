using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            var encryptedMessage = Console.ReadLine()
                .ToCharArray();
            var numbers = encryptedMessage
                .Where(x => isNumber(x))
                .Select(x => (int)char.GetNumericValue(x))
                .ToList();
            var noNumbers = encryptedMessage.
                Where(x => !isNumber(x))
                .ToList();
            var take = numbers
                .Where((x, i) => i % 2 == 0)
                .ToList();
            var skip = numbers
                .Where((x, i) => i % 2 == 1)
                .ToList();

            int total = 0;
            List<char> result = new List<char>();
            for (int i = 0; i < take.Count; i++)
            {
                var skipped = noNumbers.Skip(total).ToList();
                var taked = skipped.Take(take[i]).ToList();
                result = result.Concat(taked).ToList();

                total += skip[i] + take[i];
            }
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }

        private static bool isNumber(char x)
             => '0' <= x && x <= '9';
    }
}
