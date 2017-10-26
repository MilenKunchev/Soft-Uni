using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            foreach (var item in text)
            {
                string word = item;
                bool allIsUppercase = true;
                bool allislowercase = true;

                for (int i = 0; i < word.Length; i++)
                {
                    char character = word[i];

                    if (char.IsUpper(character))
                    {
                        allislowercase = false;
                    }
                    else if (char.IsLower(character))
                    {
                        allIsUppercase = false;
                    }
                    else
                    {
                        allislowercase = false;
                        allIsUppercase = false;
                    }
                }
                if (allIsUppercase)
                {
                    upperCaseWords.Add(word);
                }
                else if (allislowercase)
                {
                    lowerCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));
        }
    }
}
