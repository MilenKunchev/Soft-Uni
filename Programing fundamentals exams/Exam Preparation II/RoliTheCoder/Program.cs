using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> eventIdAndName = new Dictionary<int, string>();
            Dictionary<string, List<string>> eventNameAndParticipant = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Time for Code")
            {
                string[] request = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                bool isValidRequest = CheckRequest(request, eventIdAndName);

                if (isValidRequest)
                {
                    AddDataToDicts(request, eventNameAndParticipant);
                }
            }

            PrintResult(eventIdAndName, eventNameAndParticipant);
        }

        private static void PrintResult(Dictionary<int, string> eventIdAndName, Dictionary<string, List<string>> eventNameAndParticipant)
        {
            foreach (var @event in eventNameAndParticipant.OrderByDescending(c => c.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{@event.Key} - {@event.Value.Count}");

                foreach (var participant in @event.Value.OrderBy(n => n))
                {
                    Console.WriteLine(participant);
                }
            }
        }

        private static void AddDataToDicts(string[] request, Dictionary<string, List<string>> eventNameAndParticipant)
        {
            string eventName = request[1].Remove(0, 1);

            if (!eventNameAndParticipant.ContainsKey(eventName))
            {
                eventNameAndParticipant[eventName] = new List<string>();
            }

            for (int i = 2; i < request.Length; i++)
            {
                string participant = request[i];

                    if (!eventNameAndParticipant[eventName].Contains(participant))
                    {
                        eventNameAndParticipant[eventName].Add(participant);
                    }
            }

        }

        private static bool CheckRequest(string[] request, Dictionary<int, string> eventIdAndName)
        {
            int id = int.Parse(request[0]);
            string eventName = request[1];

            if (eventName[0] != '#')
            {
                return false;
            }

            if (eventIdAndName.ContainsKey(id))
            {
                if (eventIdAndName[id] != eventName)
                {
                    return false;
                }
            }
            else
            {
                eventIdAndName[id] = eventName;
            }

            return true;


        }
    }
}
