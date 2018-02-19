
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var ticket in tickets)
            {
                bool isValidTicket = CheckForValidTickt(ticket);

                if (isValidTicket)
                {
                    string ticketLeftPart = ticket.Substring(0, 10);
                    string ticketRightPart = ticket.Substring(10);

                    string pattern = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}";
                    Match matchLeft = Regex.Match(ticketLeftPart, pattern);
                    Match matchRight = Regex.Match(ticketRightPart, pattern);

                    if (matchLeft.Success && matchRight.Success)
                    {
                        char symbolLeftMatch = matchLeft.ToString()[0];
                        char symbolRigthtPart = matchRight.ToString()[0];
                        int countMatchSymbols = Math.Min(matchLeft.Length, matchRight.Length);

                        bool isWiningTicket = CheckForWinCombination(symbolLeftMatch, symbolRigthtPart);

                        if (isWiningTicket)
                        {
                            char matchSymbol = symbolLeftMatch;
                            if (countMatchSymbols == 10)
                            {
                                Console.WriteLine($"ticket \"{ ticket}\" - {countMatchSymbols}{symbolLeftMatch} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ ticket}\" - {countMatchSymbols}{symbolLeftMatch}");
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }

                else
                {
                    Console.WriteLine("invalid ticket");
                }

            }
        }

        private static bool CheckForWinCombination(char symbolLeftMatch, char symbolRigthtPart)
        {
            if (symbolLeftMatch == symbolRigthtPart)
            {
                return true;
            }
            return false;
        }

        private static bool CheckForValidTickt(string ticket)
        {
            if (ticket.Length == 20)
            {
                return true;
            }
            return false;
        }
    }
}