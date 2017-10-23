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
            bool checkForEnd = false;
            while (!checkForEnd)
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
                    case "END":
                        checkForEnd = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
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
            if (positionToReplace < 0 || positionToReplace >= arrayOfStrings.Length)
            {
                Console.WriteLine("Invalid input!");
                return arrayOfStrings;
            }
            arrayOfStrings[positionToReplace] = commandArray[2];
            return arrayOfStrings;
        }
    }
}
