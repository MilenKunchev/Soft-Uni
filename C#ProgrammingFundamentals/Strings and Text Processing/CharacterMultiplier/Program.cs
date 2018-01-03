using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var firstWord = input[0].ToCharArray();
            var secondWord = input[1].ToCharArray();

            int result = 0;

            if (firstWord.Length == secondWord.Length)
            {
                result = MultiplyCharactersWithTheSameLength(firstWord, secondWord);
            }
            if (firstWord.Length > secondWord.Length)
            {
                result = MultiplayCharectersWithDifferentLength(firstWord, secondWord);
            }
            if (firstWord.Length < secondWord.Length)
            {
                result = MultiplayCharectersWithDifferentLength(secondWord, firstWord);
            }
            Console.WriteLine(result);
        }

        private static int MultiplayCharectersWithDifferentLength(char[] biggerWord, char[] smallerWord)
        {
            int result = 0;
            int lastIndex = 0;

            for (int i = 0; i < smallerWord.Length; i++)
            {
                int firstWordValue = biggerWord[i];
                int secondWordValue = smallerWord[i];
                result += firstWordValue * secondWordValue;
                lastIndex++;
            }

            for (int i = lastIndex; i < biggerWord.Length; i++)
            {
                int nextCharValue = biggerWord[i];
                result += nextCharValue;
            }

            return result;
        }

        private static int MultiplyCharactersWithTheSameLength(char[] firstWord, char[] secondWord)
        {
            int result = 0;
            for (int i = 0; i < firstWord.Length; i++)
            {
                int firstWordValue = firstWord[i];
                int secondWordValue = secondWord[i];
                result += firstWordValue * secondWordValue;
            }
            return result;
        }
    }
}
