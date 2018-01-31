using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "end")
            {
                string[] commandsArray = commands.Split().ToArray();

                if (commandsArray[0] == "reverse")
                {
                    Reverse(commandsArray, inputLine);
                }

                if (commandsArray[0] == "sort")
                {
                    Sort(commandsArray, inputLine);
                }

                if (commandsArray[0] == "rollLeft")
                {
                    RollLeft(commandsArray, inputLine);
                }

                if (commandsArray[0] == "rollRight")
                {
                    RollRight(commandsArray, inputLine);
                }
            }
            Console.WriteLine($"[{string.Join(", ", inputLine)}]");
        }

        private static void RollRight(string[] commandsArray, List<string> inputLine)
        {
            int rollCount = int.Parse(commandsArray[1]);

            if (rollCount >= 0)
            {
                for (int j = 0; j < rollCount % inputLine.Count; j++)
                {
                    string lastElement = inputLine[inputLine.Count - 1];
                    for (int i = inputLine.Count - 1; i > 0; i--)
                    {
                        inputLine[i] = inputLine[i - 1];
                    }
                    inputLine[0] = lastElement;
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        private static void RollLeft(string[] commandsArray, List<string> inputLine)
        {
            int rollCount = int.Parse(commandsArray[1]);

            if (rollCount >= 0)
            {
                for (int j = 0; j < rollCount % inputLine.Count; j++)
                {
                    string firstElement = inputLine[0];
                    for (int i = 0; i < inputLine.Count - 1; i++)
                    {
                        inputLine[i] = inputLine[i + 1];
                    }
                    inputLine[inputLine.Count - 1] = firstElement;
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        private static void Sort(string[] commandsArray, List<string> inputLine)
        {
            int start = int.Parse(commandsArray[2]);
            int count = int.Parse(commandsArray[4]);

            bool validParameters = CheckInputParameters(start, count, inputLine);

            if (validParameters)
            {
                inputLine.Sort(start, count, StringComparer.InvariantCulture);
            }
        }

        private static void Reverse(string[] commandsArray, List<string> inputLine)
        {
            int start = int.Parse(commandsArray[2]);
            int count = int.Parse(commandsArray[4]);

            bool validParameters = CheckInputParameters(start, count, inputLine);

            if (validParameters)
            {
                inputLine.Reverse(start, count);
            }
        }

        private static bool CheckInputParameters(int start, int count, List<string> inputLine)
        {
            int listCount = inputLine.Count;

            long maxCount = (long)count + start;

            bool validStart = start >= 0 && start < listCount;

            bool validCount = count >= 0 && maxCount <= listCount;

            if (validStart && validCount)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
                return false;
            }
        }
    }
}
