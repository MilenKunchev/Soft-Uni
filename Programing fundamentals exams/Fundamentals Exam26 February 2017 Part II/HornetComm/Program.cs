using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class Program
    {
        private static string s;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> privateMessages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (input != "Hornet is Green")
            {
                string[] inputArr = input.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputArr.Length == 2)
                {
                    string firstQuery = inputArr[0];
                    string secondQuery = inputArr[1];

                    int countOfDigits = GetCountOfDigits(firstQuery);

                    bool isSecondQueryValid = CheckSecondQueryValid(secondQuery);
                    bool isOnlyDigits = countOfDigits == firstQuery.Count();
                    bool isAnythingButDigits = countOfDigits == 0;

                    if (isOnlyDigits && isSecondQueryValid) //private message 
                    {
                        string recipientCode = ReverceFirstQuery(firstQuery);
                        string privateMessage = recipientCode + " -> " + secondQuery;
                        privateMessages.Add(privateMessage);
                    }
                    if (isAnythingButDigits && isSecondQueryValid) //Broadcasts
                    {
                        string frequency = ReplaceSmallAndCapitalLetters(secondQuery);
                        string broadcast = frequency + " -> " + firstQuery;
                        broadcasts.Add(broadcast);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Messages:");
            if (privateMessages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in privateMessages)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static string ReplaceSmallAndCapitalLetters(string secondQuery)
        {
            char[] arr = secondQuery.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                {
                    arr[i] = char.ToLower(arr[i]);
                }
                else if (char.IsLower(arr[i]))
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
            }

            return new string(arr);
        }

        private static string ReverceFirstQuery(string firstQuery)
        {
            char[] arr = firstQuery.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private static bool CheckSecondQueryValid(string secondQuery)
        {
            string pattern = @"^[0-9a-zA-Z]+$";
            Match rx = Regex.Match(secondQuery, pattern);
            bool IsValid = rx.Success;
            return IsValid;
        }

        static int GetCountOfDigits(string firstQuery)
        {
            int count = 0;
            int num = 0;
            foreach (var item in firstQuery)
            {
                bool isNum = int.TryParse(item.ToString(), out num);
                if (isNum)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
