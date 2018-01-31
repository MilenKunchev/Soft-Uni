using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            StringBuilder resultMessage = new StringBuilder();
            HashSet<char> unickSymbols = new HashSet<char>();

            // Split strings with Regex
            string pattern = @"\D+\d+";

            foreach (Match match in Regex.Matches(inputLine, pattern))
            {
                // parse matches to string
                string anyMatch = match.ToString();

                // separation nums and symbols 
                string number = string.Empty;
                string symbols = string.Empty;

                for (int i = 0; i < anyMatch.Length; i++)
                {
                    if (anyMatch[i] > 47 && anyMatch[i] < 58)
                    {
                        number += anyMatch[i];
                    }
                    else
                    {
                        char thisSymbol = char.ToUpper(anyMatch[i]);
                        symbols += thisSymbol;
                    }
                }
                int repeatCount = int.Parse(number);

                // add symbols to result massage
                for (int i = 0; i < repeatCount; i++)
                {
                    resultMessage.Append(symbols);
                    foreach (var symbol in symbols)
                    {
                        unickSymbols.Add(symbol);
                    }

                }
            }

            Console.WriteLine($"Unique symbols used: {unickSymbols.Count}");
            Console.WriteLine(resultMessage);
        }
    }
}
