using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Cubic_sMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string cubicLine = Console.ReadLine();

            while (cubicLine != "Over!")
            {
                int messageLength = int.Parse(Console.ReadLine());

                string pattern = $@"^(\d+)([a-zA-Z]{{{messageLength}}})([^a-zA-Z]*?)$";
                Regex rx = new Regex(pattern);
                MatchCollection matches = rx.Matches(cubicLine);

                if (Regex.IsMatch(cubicLine, pattern))
                {
                    foreach (Match match in matches)
                    {
                        string elementsAfterMessage = (match.Groups[3]).ToString();
                        string digitsAfterMessage = GetDigitsAfterMessage(elementsAfterMessage);
                        string digitsBeformessage = (match.Groups[1]).ToString();
                        string message = (match.Groups[2]).ToString();
                        string indexes = string.Concat(digitsBeformessage, digitsAfterMessage);

                        StringBuilder decryptedMessage = new StringBuilder();

                        foreach (var index in indexes)
                        {
                            int indexValue = int.Parse(index.ToString());
                            if (indexValue < 0 || indexValue >= messageLength)
                            {
                                decryptedMessage.Append(" ");
                            }
                            else
                            {
                                decryptedMessage.Append(message[indexValue]);
                            }
                        }
                        Console.WriteLine($"{message} == {decryptedMessage}");
                    }
                }

                cubicLine = Console.ReadLine();
            }
        }

        private static string GetDigitsAfterMessage(string elementsAfterMessage)
        {
            StringBuilder digits = new StringBuilder();

            foreach (var element in elementsAfterMessage)
            {
                int digit = 0;
                bool isDigit = int.TryParse(element.ToString(), out digit);

                if (isDigit)
                {
                    digits.Append(digit);
                }
            }
            return digits.ToString();
        }
    }
}
