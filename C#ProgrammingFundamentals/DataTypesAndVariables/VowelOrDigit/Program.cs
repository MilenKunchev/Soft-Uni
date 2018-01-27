using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            int digit = 0;
            bool isDigit = int.TryParse(symbol.ToString(), out digit);

            char[] vowel = { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y' };
            if (isDigit)
            {
                Console.WriteLine("digit");
            }
            else if (vowel.Contains(symbol))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
