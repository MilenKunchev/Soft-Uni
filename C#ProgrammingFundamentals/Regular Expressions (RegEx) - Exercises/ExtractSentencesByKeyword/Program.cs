using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            var sentences = Console.ReadLine().Split('!', '.', '?');

            string pattern = @"\b(" + keyword + @"+)\b";

            foreach (var sentence in sentences)
            {
                foreach (Match item in Regex.Matches(sentence, pattern))
                {
                    Console.WriteLine(sentence);
                }
            }





        }
    }
}
