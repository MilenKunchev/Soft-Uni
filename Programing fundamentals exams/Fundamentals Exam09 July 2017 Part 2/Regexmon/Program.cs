using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string didiPattern = @"[^a-zA-Z-]+";
            string bojoPattern = @"[a-zA-Z]+-[a-zA-Z]+"; ;

            while (true)
            {
                var didiMatch = Regex.Match(text, didiPattern);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch);
                    text = text.Substring(text.IndexOf(didiMatch.Value) + didiMatch.Value.Length);
                }
                else
                {
                    break;
                }

                var bojoMatch = Regex.Match(text, bojoPattern);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch);
                    text = text.Substring(text.IndexOf(bojoMatch.Value) + bojoMatch.Value.Length);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
