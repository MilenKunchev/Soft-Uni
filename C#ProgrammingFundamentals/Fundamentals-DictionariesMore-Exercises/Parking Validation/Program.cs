using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> usersData = new Dictionary<string, string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> input = ReadInput();
                string command = input[0];
                string username = input[1];

                if (command == "register")
                {
                    string licensePlateNumber = input[2];
                    bool userInfoIsValid = CheckForValiduserInfo(usersData, username, licensePlateNumber);
                    if (userInfoIsValid)
                    {
                        usersData[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (usersData.ContainsKey(username))
                    {
                        usersData.Remove(username);
                        Console.WriteLine($"user {username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            foreach (var user in usersData)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }

        }

        private static bool CheckForValiduserInfo(Dictionary<string, string> usersData, string username, string licensePlateNumber)
        {
            //  if a user tries to register another license plate
            if (usersData.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {usersData[username]}");
                return false;
            }

            //If the license plate is invalid
            bool licensePlateIsInvalidNumber = CheckLicensePlateNumber(licensePlateNumber);
            if (licensePlateIsInvalidNumber)
            {
                Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                return false;
            }

            // If the user tries to register someone else’s license plate
            else if (usersData.ContainsValue(licensePlateNumber))
            {
                Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                return false;
            }

            //	If the aforementioned checks pass successfully

            return true;


        }

        private static bool CheckLicensePlateNumber(string licensePlateNumber)
        {
            // NOT 8 characters long ?
            if (licensePlateNumber.Length < 8 || licensePlateNumber.Length > 8)
            {
                return true;
            }
            // Its first 2 and last 2 characters are NOT uppercase Latin letters 
            string firstAndLasTwoElements = licensePlateNumber.Remove(2, 4);
            foreach (var item in firstAndLasTwoElements)
            {
                if (item > 90 || item < 65)
                {
                    return true;
                }
            }

            // The 4 characters in the middle are NOT digits 
            string midlePart = licensePlateNumber.Remove(6, 2).Remove(0, 2);
            foreach (var item in midlePart)
            {
                if (item < 48 || item > 57)
                {
                    return true;
                }
            }

            return false;
        }

        private static List<string> ReadInput()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            return input;
        }
    }
}
