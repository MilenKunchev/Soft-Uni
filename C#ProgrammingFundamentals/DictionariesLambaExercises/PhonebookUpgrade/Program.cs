using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();


            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] phoneParameterts = input.Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries);

                string command = phoneParameterts[0];

                if (command == "A")
                {
                    string key = phoneParameterts[1];
                    string value = phoneParameterts[2];
                    phoneBook[key] = value;
                }
                else if (command == "S")
                {
                    string key = phoneParameterts[1];
                    if (phoneBook.ContainsKey(key))
                    {
                        Console.WriteLine($"{key} -> {phoneBook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {key} does not exist.");
                    }
                }
                else
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }

                input = Console.ReadLine();

            }
        }
    }
}
