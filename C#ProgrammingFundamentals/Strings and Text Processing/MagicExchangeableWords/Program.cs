using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            string firstWord = input[0];
            string secondWord = input[1];

            var firstWordArray = firstWord.ToCharArray().Distinct().ToArray();
            var secondWordArray = secondWord.ToCharArray().Distinct().ToArray();

            Console.WriteLine(firstWordArray.Length == secondWordArray.Length ? "true" : "false");
        }
    }
}
