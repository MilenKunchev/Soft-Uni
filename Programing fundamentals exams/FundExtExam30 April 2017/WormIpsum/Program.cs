namespace WormIpsum
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
            string validationPattern = @"[A-Z].*?[^.]\.";
            string wordPattern = @"(\b\w+\b)";
            string validSentence = string.Empty;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Worm Ipsum")
            {
                Match match = Regex.Match(input, validationPattern);

                if (match.Success && match.Length == input.Length)
                {
                    validSentence = match.ToString();

                    foreach (Match word in Regex.Matches(validSentence, wordPattern))
                    {
                        string thisWord = word.ToString();


                        Dictionary<char, int> characters = new Dictionary<char, int>();

                        foreach (var character in thisWord)
                        {
                            if (!characters.ContainsKey(character))
                            {
                                characters[character] = 1;
                            }
                            else
                            {
                                characters[character]++;
                            }
                        }
                        var orderedLetters = characters.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                        if (orderedLetters.First().Value > 1)
                        {
                            char repeatedCharacter = orderedLetters.First().Key;
                            string newWord = new string(repeatedCharacter, thisWord.Length);
                            validSentence = validSentence.Replace(thisWord, newWord);
                        }
                    }
                    Console.WriteLine(validSentence);
                }
            }
        }
    }
}
