

namespace SpyGram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main(string[] args)
        {
            string privateKey = Console.ReadLine();

            Dictionary<string, List<string>> pendingMessages = new Dictionary<string, List<string>>();

            string pattern = @"^TO: ([A-Z]+); [A-Z]+: (.+);$";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string recipient = match.Groups[1].ToString();

                    string encryptedMessage = EncryptMessage(privateKey, input);

                    if (!pendingMessages.ContainsKey(recipient))
                    {
                        pendingMessages[recipient] = new List<string>();
                        pendingMessages[recipient].Add(encryptedMessage);
                    }
                    else
                    {
                        pendingMessages[recipient].Add(encryptedMessage);
                    }                    
                }
            }
            foreach (var recipient in pendingMessages.OrderBy(x => x.Key))
            {
                foreach (var message in recipient.Value)
                {
                    Console.WriteLine(message);
                }                
            }
        }

        static string EncryptMessage(string privateKey, string message)
        {
            StringBuilder encrypted = new StringBuilder();

            int messageSymbolsCount = message.Length;
            int messageIndex = -1;

            while (messageIndex < messageSymbolsCount)
            {
                for (int i = 0; i < privateKey.Length; i++)
                {
                    messageIndex++;
                    int keyDigit = (int)char.GetNumericValue(privateKey[i]);

                    if (messageIndex == messageSymbolsCount) //If message index count = message length go to while check. 
                    {
                        break;
                    }

                    int symbolCode = message[messageIndex];
                    int newSymbol = symbolCode + keyDigit;

                    encrypted.Append((char)newSymbol);
                }
            }

            return encrypted.ToString();
        }
    }
}
