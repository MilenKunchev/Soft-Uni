using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            var squareNumbers = ReturnSquareNumbers(numbers);
            var sortedNumbers = SortNumbers(squareNumbers);
            
            Console.WriteLine(string.Join(" ", sortedNumbers));
        }

        private static List<int> SortNumbers(List<int> squareNumbers)
        {            
            squareNumbers.Sort((a, b) => b.CompareTo(a));
            return squareNumbers;
        }

        private static List<int> ReturnSquareNumbers(List<int> numbers)
        {
            List<int> squareNumbers = new List<int>();
            foreach (var item in numbers)
            {
                bool isItSquare = (Math.Sqrt(item)) == ((int)Math.Sqrt(item));
                if (isItSquare)
                {
                    squareNumbers.Add(item);
                }
            }
            return squareNumbers;
        }
    }
}
