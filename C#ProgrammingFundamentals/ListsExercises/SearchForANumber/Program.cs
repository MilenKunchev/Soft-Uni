using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool foundNumber = SearchForANumber(numbers, commands);
            Console.WriteLine(foundNumber ? "YES!" : "NO!");
        }

        private static bool SearchForANumber(List<int> numbers, int[] commands)
        {
            bool foundNumber = false;
            int numbersToGet = commands[0];
            int numbersTodelete = commands[1];
            int numberWeSearch = commands[2];

            numbers = numbers.GetRange(0, numbersToGet);
            numbers.RemoveRange(0, numbersTodelete);
            foreach (var item in numbers)
            {
                if (item==numberWeSearch)
                {
                    foundNumber = true;
                    break;
                }                
            }
            return foundNumber;
        }
    }
}
