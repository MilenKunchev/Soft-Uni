using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            var byteArray = Console.ReadLine().Split().ToList();

            List<string> elementsWithLengthTwo = GetElementsWithLengthTwo(byteArray);
            List<string> reversedElements = ReverseElements(elementsWithLengthTwo);
            List<char> characters = ConvertElementsToCharacters(reversedElements);
            PrintResult(characters);
        }

        private static void PrintResult(List<char> characters)
        {
            Console.WriteLine(string.Join("", characters));
        }

        private static List<char> ConvertElementsToCharacters(List<string> reversedElements)
        {
            List<char> characters = new List<char>();
            foreach (var hex in reversedElements)
            {
                int num = int.Parse(hex, NumberStyles.AllowHexSpecifier);
                char cnum = (char)num;
                characters.Add(cnum);
            }
            return characters;
        }

        private static List<string> ReverseElements(List<string> elementsWithLengthTwo)
        {
            // Reverse bytes position
            elementsWithLengthTwo.Reverse();

            // Reverse byte elements
            List<string> reversedElements = new List<string>();
            foreach (var element in elementsWithLengthTwo)
            {
                char[] charOfElements = element.Reverse().ToArray();
                string reversedByte = string.Join("", charOfElements);
                reversedElements.Add(reversedByte);
            }
            return reversedElements;
        }

        private static List<string> GetElementsWithLengthTwo(List<string> byteArray)
        {
            List<string> elementsWithLengthTwo = new List<string>();
            for (int i = 0; i < byteArray.Count; i++)
            {
                string element = byteArray[i];
                if (element.Length == 2)
                {
                    elementsWithLengthTwo.Add(byteArray[i]);
                }
            }
            return elementsWithLengthTwo;
        }
    }
}
