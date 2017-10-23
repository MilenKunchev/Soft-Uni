using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ').ToArray();
            int linesOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < linesOfCommands; i++)
            {
                string[] commandArray = Console.ReadLine().Split(' ').ToArray();
                string command = commandArray[0];
                switch (command)
                {
                    case "Reverse":
                        arrayOfStrings = ToReverse(arrayOfStrings);
                        break;
                    case "Distinct":
                        arrayOfStrings = ToDistinct(arrayOfStrings);
                        break;
                    case "Replace":
                        arrayOfStrings = ToReplace(arrayOfStrings, commandArray);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", arrayOfStrings));
        }

        private static string[] ToReverse(string[] arrayOfStrings)
        {
            arrayOfStrings = arrayOfStrings.Reverse().ToArray();
            return arrayOfStrings;
        }

        private static string[] ToDistinct(string[] arrayOfStrings)
        {
            arrayOfStrings = arrayOfStrings.Distinct().ToArray();
            return arrayOfStrings;
        }

        private static string[] ToReplace(string[] arrayOfStrings, string[] commandArray)
        {
            int positionToReplace = int.Parse(commandArray[1]);
            arrayOfStrings[positionToReplace] = commandArray[2];
            return arrayOfStrings;
        }
    }
}
