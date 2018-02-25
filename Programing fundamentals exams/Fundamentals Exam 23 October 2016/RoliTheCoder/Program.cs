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
            var idAndEventName = new Dictionary<string, string>();
            var eventNameAndParicipants = new Dictionary<string, HashSet<string>>();

            string request = string.Empty;

            while ((request = Console.ReadLine()) != "Time for Code")
            {
                string[] requestTokens = request
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                bool isValidLine = CheckLineIsItValid(requestTokens);

                if (isValidLine)
                {
                    string eventId = requestTokens[0];
                    string eventName = requestTokens[1].Remove(0, 1);

                    AddIdAndEventNameToDict(idAndEventName, eventId, eventName);

                    if (idAndEventName.ContainsKey(eventId) && idAndEventName[eventId] == eventName)
                    {
                        if (!eventNameAndParicipants.ContainsKey(eventName))
                        {
                            eventNameAndParicipants[eventName] = new HashSet<string>();
                            AddNamesToDictWithParticipantNames(eventNameAndParicipants, requestTokens, eventName);
                        }
                        else
                        {
                            AddNamesToDictWithParticipantNames(eventNameAndParicipants, requestTokens, eventName);
                        }
                    }
                }
            }
            PrintResult(eventNameAndParicipants);

        }

        private static void PrintResult(Dictionary<string, HashSet<string>> eventNameAndParicipants)
        {
            foreach (var events in eventNameAndParicipants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{events.Key} - {events.Value.Count}");
                foreach (var participant in events.Value.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }

        private static void AddNamesToDictWithParticipantNames(Dictionary<string, HashSet<string>> eventNameAndParicipants
            , string[] requestTokens, string eventName)
        {
            for (int i = 2; i < requestTokens.Length; i++)
            {
                if (requestTokens[i][0] == '@')
                {
                    string participantName = requestTokens[i];
                    eventNameAndParicipants[eventName].Add(participantName);
                }
            }
        }

        private static void AddIdAndEventNameToDict(Dictionary<string, string> idAndEventName, string eventId, string eventName)
        {
            if (!idAndEventName.ContainsKey(eventId))
            {
                idAndEventName[eventId] = eventName;
            }
        }

        private static bool CheckLineIsItValid(string[] requestTokens)
        {
            char hashtagNeeded = requestTokens[1][0];

            if (hashtagNeeded == '#')
            {
                return true;
            }
            return false;
        }
    }
}
