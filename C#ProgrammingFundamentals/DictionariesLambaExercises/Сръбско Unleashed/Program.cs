using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СръбскоUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> concertData = new
                Dictionary<string, Dictionary<string, int>>();

            string[] input = ReadInput();

            while (input[0] != "End")
            {
                bool inputIsIncorrect = CheckInput(input);
                if (inputIsIncorrect)
                {
                    input = ReadInput();
                }
                else
                {
                    WriteDataToDictionary(input, concertData);
                    input = ReadInput();
                }
            }
            PrintResult(concertData);
        }

        private static void PrintResult(Dictionary<string,
            Dictionary<string, int>> concertData)
        {
            foreach (var venue in concertData)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }

        private static void WriteDataToDictionary(string[] input,
            Dictionary<string, Dictionary<string, int>> concertData)
        {
            var removeNameSpace = input[0].Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            string singerName = string.Join(" ", removeNameSpace);

            var singerInfo = input[1].Split().ToList();
            int ticketCount = int.Parse(singerInfo.Last());
            singerInfo.RemoveAt(singerInfo.Count - 1);
            int ticketPrice = int.Parse(singerInfo.Last());
            singerInfo.RemoveAt(singerInfo.Count - 1);
            string venue = string.Join(" ", singerInfo);
            int moneyFromConcert = ticketPrice * ticketCount;
            if (!concertData.ContainsKey(venue))
            {
                concertData[venue] = new Dictionary<string, int>();
                concertData[venue][singerName] = moneyFromConcert;
            }
            else if (!concertData[venue].ContainsKey(singerName))
            {
                concertData[venue][singerName] = moneyFromConcert;
            }
            else
            {
                concertData[venue][singerName] += moneyFromConcert;
            }
        }

        private static bool CheckInput(string[] input)
        {
            List<string> name = input[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> venue = input[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            bool inputIsIncorrect = false;
            if (input[0].Last() != ' ')
            {
                inputIsIncorrect = true;
            }
            else if (name.Count > 3 || venue.Count > 5)
            {
                inputIsIncorrect = true;
            }
            else
            {
                string[] concertInfo = input[1].Split().ToArray();
                try
                {
                    int.Parse(concertInfo.Last());
                    int.Parse(concertInfo[concertInfo.Length - 2]);
                }
                catch (Exception)
                {
                    inputIsIncorrect = true;
                }
            }
            return inputIsIncorrect;
        }

        private static string[] ReadInput()
        {
            string[] input = Console.ReadLine().Split('@').ToArray();
            return input;
        }
    }
}
