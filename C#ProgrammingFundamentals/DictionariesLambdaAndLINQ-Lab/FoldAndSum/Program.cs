using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int k = numbers.Count / 4;
            // Get first row
            var leftRow = numbers.Take(k).Reverse();
            var rightRow = numbers.Skip(k + (2 * k)).Take(k).Reverse();
            var firstRow = leftRow.Concat(rightRow).ToList();
            // Get second row
            var secondRow = numbers.Skip(k).Take(2 * k).ToList();
            var sum = firstRow.Select((x, index) => x + secondRow[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
