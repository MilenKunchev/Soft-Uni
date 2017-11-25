using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.RemoveAll(x => x % 2 == 1);
            var average = numbers.Sum() / numbers.Count;
            var result = numbers.Select(x => x > average ? x + 1 : x - 1).ToList();

            Console.WriteLine(string.Join(" ",result));
            
        }
    }
}
