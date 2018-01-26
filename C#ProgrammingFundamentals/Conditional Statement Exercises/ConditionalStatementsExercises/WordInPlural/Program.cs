using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                string tempWord = word.Remove(word.Length - 1);
                word = tempWord + "ies";
            }

            else if (word.EndsWith("ch") ||
                word.EndsWith("o") ||
                word.EndsWith("s") ||
                word.EndsWith("sh") ||
                word.EndsWith("x") ||
                word.EndsWith("z"))
            {
                string tempWord = word + "es";
                word = tempWord;
            }

            else
            {
                string tempWord = word + "s";
                word = tempWord;
            }

            Console.WriteLine(word);
        }
    }
}
