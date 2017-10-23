using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                string resultToPrint = GetCharNumber(word[i]);
                Console.WriteLine(resultToPrint);
            }            
        }

        private static string GetCharNumber(char v)
        {
            char[] alphabet = new char[26];
            char letter = 'a';
            string result = string.Empty;
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = letter;
                letter++;
            }
            for (int i = 0; i < alphabet.Length; i++)
            {
                letter = alphabet[i];
                if (v==letter)
                {
                    result = $"{v} -> {i}";
                }
            }
            return result;
        }        
    }
}
