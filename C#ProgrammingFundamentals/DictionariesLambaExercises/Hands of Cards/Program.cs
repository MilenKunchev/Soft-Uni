using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> people = new Dictionary<string, List<string>>();
            Dictionary<string, int> result = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                var nameAndCards = input.Split(':');
                var name = nameAndCards[0];
                var cards = nameAndCards[1]
                    .Trim()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                AddUnickCardsToPlayer(name, cards, people);

                input = Console.ReadLine();
            }
            PutCardPontsToResultDict(people, result);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static void PutCardPontsToResultDict(Dictionary<string, List<string>> people, Dictionary<string, int> result)
        {
            foreach (var item in people)
            {
                var cards = item.Value;
                int points = 0;
                Dictionary<char, int> powerOfCards = new Dictionary<char, int>();
                #region dictionary elements
                powerOfCards['2'] = 2;
                powerOfCards['3'] = 3;
                powerOfCards['4'] = 4;
                powerOfCards['5'] = 5;
                powerOfCards['6'] = 6;
                powerOfCards['7'] = 7;
                powerOfCards['8'] = 8;
                powerOfCards['9'] = 9;
                powerOfCards['1'] = 10;
                powerOfCards['J'] = 11;
                powerOfCards['Q'] = 12;
                powerOfCards['K'] = 13;
                powerOfCards['A'] = 14;
                #endregion
                Dictionary<char, int> typeOfCards = new Dictionary<char, int>();
                #region Type of cards
                typeOfCards['S'] = 4;
                typeOfCards['H'] = 3;
                typeOfCards['D'] = 2;
                typeOfCards['C'] = 1;

                #endregion
                for (int i = 0; i < cards.Count; i++)
                {
                    string card = cards[i];
                    char power = card.First();
                    char type = card.Last();

                    points += powerOfCards[power] * typeOfCards[type];
                }
                result[item.Key] = points;
            }
        }

        private static void AddUnickCardsToPlayer(string name, List<string> cards, Dictionary<string, List<string>> people)
        {
            if (!people.ContainsKey(name))
            {
                people[name] = cards.Distinct().ToList();
            }
            else
            {
                List<string> oldCards = new List<string>();

                people.TryGetValue(name, out oldCards);

                people[name] = oldCards.Concat(cards).Distinct().ToList();
            }

        }
    }
}

