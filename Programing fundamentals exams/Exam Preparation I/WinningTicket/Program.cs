using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ticketsLine = Console.ReadLine().Split(new [] { ','}, StringSplitOptions.RemoveEmptyEntries).Select(t=>t.Trim()).ToArray();
           
            foreach (var ticket in ticketsLine)
            {
                CheckTicked(ticket);
            }
        }

        private static void CheckTicked(string ticket)
        {
            Regex rx = new Regex(@"([#]{6,10}|[$]{6,10}|[\^]{6,10}|[@]{6,10})(.*)(\1)");
            MatchCollection matches = rx.Matches(ticket);

            //Invalid ticket
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
            }

            //  No match ticket
            else if (matches.Count == 0)
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
            else // win ticket
            {
                String winCharacters = matches[0].Groups[1].ToString();
                int countOfMatches = winCharacters.Length;

                if (countOfMatches == 10)  //Jackpot
                {
                    string WinResult = countOfMatches + winCharacters[0].ToString();

                    Console.WriteLine($"ticket \"{ticket}\" - {WinResult} Jackpot!");
                }
                else // win 6->9
                {
                    string WinResult = countOfMatches + winCharacters[0].ToString();
                    Console.WriteLine($"ticket \"{ticket}\" - {WinResult}");
                }

            }
        }
    }
}
