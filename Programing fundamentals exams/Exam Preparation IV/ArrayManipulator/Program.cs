using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            //  80/100
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                string masterCommand = command[0];

                switch (masterCommand)
                {
                    case "exchange":
                        int exchangeIndex = int.Parse(command[1]);
                        if (exchangeIndex < inputArray.Length && exchangeIndex >= 0)
                        {
                            inputArray = ExchangeArray(inputArray, exchangeIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "max":
                        int maxNumIndex = FindMaxEvenOrOddIndex(command, inputArray); // If no matches maxNumIndex = -1.                        
                        Console.WriteLine(maxNumIndex >= 0 ? $"{maxNumIndex}" : "No matches");
                        break;

                    case "min":
                        int minNumIndex = FindMinEvenOddIndex(command, inputArray); // If no matches maxNumIndex = -1.                        
                        Console.WriteLine(minNumIndex >= 0 ? $"{minNumIndex}" : "No matches");
                        break;

                    case "first":
                    case "last":
                        int count = int.Parse(command[1]);
                        if (count > inputArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            List<int> elements = FindElements(command, inputArray);
                            Console.WriteLine($"[{string.Join(", ", elements)}]");
                        }
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }

        static List<int> FindElements(string[] command, int[] inputArray)
        {
            List<int> elements = new List<int>();
            int count = int.Parse(command[1]);
            int divideResult = command[2] == "even" ? 0 : 1;

            if (command[0] == "first")
            {
                elements = inputArray.Where(x => x % 2 == divideResult).ToList();
                elements = elements.Take(count).ToList();
            }
            if (command[0] == "last")
            {
                elements = inputArray.Reverse().Where(x => x % 2 == divideResult).ToList();
                elements = elements.Take(count).Reverse().ToList();
            }
            return elements;
        }

        static int FindMaxEvenOrOddIndex(string[] command, int[] inputArray)
        {
            int maxNumIndex = -1;
            int maxNum = 0;
            int divisionResult = command[1] == "even" ? 0 : 1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == divisionResult && inputArray[i] >= maxNum)
                {
                    maxNum = inputArray[i];
                    maxNumIndex = i;
                }
            }

            return maxNumIndex;
        }

        static int FindMinEvenOddIndex(string[] command, int[] inputArray)
        {
            int minNumIndex = -1;
            int minNum = int.MaxValue;
            int divisionResult = command[1] == "even" ? 0 : 1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == divisionResult && inputArray[i] <= minNum)
                {
                    minNum = inputArray[i];
                    minNumIndex = i;
                }
            }

            return minNumIndex;
        }

        static int[] ExchangeArray(int[] inputArray, int exchangeIndex)
        {
            IEnumerable<int> leftPart = inputArray.Take(exchangeIndex + 1);
            IEnumerable<int> rightPart = inputArray.Skip(exchangeIndex + 1);

            return rightPart.Concat(leftPart).ToArray();
        }
    }
}
