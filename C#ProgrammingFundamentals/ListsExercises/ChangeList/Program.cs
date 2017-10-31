using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> result = new List<int>();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                switch (command[0])
                {
                    case "Delete":
                        numbers = DeleteElement(numbers, (int.Parse(command[1])));
                        break;
                    case "Insert":
                        numbers = InsertElemet(numbers, (int.Parse(command[1])), (int.Parse(command[2])));
                        break;
                }
                command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            // Odd or even
            switch (command[0])
            {
                case "Odd":
                    numbers = RemoveEvenElements(numbers);
                    break;
                case "Even":
                    numbers = RemoveOddElements(numbers);
                    break;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> RemoveOddElements(List<int> numbers)
        {
            numbers.RemoveAll(p => p % 2 != 0);
            return numbers;
        }

        private static List<int> RemoveEvenElements(List<int> numbers)
        {
            numbers.RemoveAll(p => p % 2 == 0);
            return numbers;
        }

        private static List<int> InsertElemet(List<int> numbers, int element, int position)
        {
            numbers.Insert(position, element);
            return numbers;
        }

        private static List<int> DeleteElement(List<int> numbers, int element)
        {
            numbers.RemoveAll(a => a == element);
            return numbers;
        }
    }
}
