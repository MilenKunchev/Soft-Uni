using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> commands = Console.ReadLine()
               .Split(' ')
               .ToList();

            while (commands[0] != "print")
            {
                switch (commands[0])
                {
                    case "add":
                        numbers = Add(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                    case "addMany":
                        numbers = AddMany(numbers, commands);
                        break;
                    case "contains":
                        PrintIndexOfSpecifiedElement(numbers, int.Parse(commands[1]));
                        break;
                    case "remove":
                        numbers = RemoveElement(numbers, int.Parse(commands[1]));
                        break;
                    case "shift":
                        numbers = ShiftElements(numbers, int.Parse(commands[1]));
                        break;
                    case "sumPairs":
                        numbers = SumPairs(numbers);
                        break;
                }
                commands = Console.ReadLine()
                .Split(' ')
                .ToList();

            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));

        }

        private static List<int> Add(List<int> numbers, int index, int element)
        {
            numbers.Insert(index, element);
            return numbers;
        }

        private static List<int> AddMany(List<int> numbers, List<string> commands)
        {
            int index = int.Parse(commands[1]);
            commands.RemoveRange(0, 2);
            List<int> numsToAdd = commands.Select(int.Parse).ToList();
            numbers.InsertRange(index, numsToAdd);
            return numbers;
        }

        private static void PrintIndexOfSpecifiedElement(List<int> numbers, int elementToSearch)
        {
            int n = numbers.IndexOf(elementToSearch);
            Console.WriteLine(n);
        }

        private static List<int> RemoveElement(List<int> numbers, int indexOfRemoveElement)
        {
            numbers.RemoveAt(indexOfRemoveElement);
            return numbers;
        }

        private static List<int> ShiftElements(List<int> numbers, int index)
        {
            List<int> newNumbers = new List<int>();
            index = index % numbers.Count;            
            newNumbers = numbers.GetRange(index, numbers.Count - index);
            numbers.RemoveRange(index, numbers.Count - index);
            newNumbers.InsertRange(newNumbers.Count, numbers);
            return newNumbers;
        }

        private static List<int> SumPairs(List<int> numbers)
        {
            List<int> newNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int nextIndex = i + 1;
                int nextElement = 0;
                if (nextIndex >= numbers.Count)
                {
                    nextElement = 0;
                }
                else
                {
                    nextElement = numbers[nextIndex];
                }
                newNumbers.Add(numbers[i] + nextElement);
                i++;
            }
            return newNumbers;
        }
    }
}
