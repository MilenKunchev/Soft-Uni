using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { '.', ',', ':', ';', '(', ')'
                    , '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            var text = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var shortWords = text.Where(x => x.Length < 5).Distinct().OrderBy(w => w);
            Console.WriteLine(string.Join(", ", shortWords));

        }
    }
}
