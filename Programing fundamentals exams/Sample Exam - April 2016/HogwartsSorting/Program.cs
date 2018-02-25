using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsSorting
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> housesCountStudents = new Dictionary<string, int>()
            {
                {"Gryffindor",0 },
                {"Slytherin" ,0 },
                {"Ravenclaw", 0},
                {"Hufflepuff", 0 }
            };

            List<KeyValuePair<string, string>> housesAndStuednts = new List<KeyValuePair<string, string>>();

            int newcomersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < newcomersCount; i++)
            {
                string[] newcomerNames = Console.ReadLine().Split().ToArray();
                string firstName = newcomerNames[0];
                string lastName = newcomerNames[1];

                int firstNameSum = SumNamesASCII(firstName);
                int lastNameSum = SumNamesASCII(lastName);
                int fullNameSum = firstNameSum + lastNameSum;

                string facultyNumber = fullNameSum.ToString() + firstName[0] + lastName[0];

                int reminder = fullNameSum % 4;

                switch (reminder)
                {
                    case 0:
                        housesAndStuednts.Add(new KeyValuePair<string, string>("Gryffindor", facultyNumber));
                        housesCountStudents["Gryffindor"]++;
                        break;

                    case 1:
                        housesAndStuednts.Add(new KeyValuePair<string, string>("Slytherin", facultyNumber));
                        housesCountStudents["Slytherin"]++;
                        break;

                    case 2:
                        housesAndStuednts.Add(new KeyValuePair<string, string>("Ravenclaw", facultyNumber));
                        housesCountStudents["Ravenclaw"]++;
                        break;

                    case 3:
                        housesAndStuednts.Add(new KeyValuePair<string, string>("Hufflepuff", facultyNumber));
                        housesCountStudents["Hufflepuff"]++;
                        break;
                }

            }

            foreach (KeyValuePair<string, string> pair in housesAndStuednts)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
            Console.WriteLine();
            foreach (var house in housesCountStudents)
            {
                Console.WriteLine($"{house.Key}: {house.Value}");
            }
        }

        static int SumNamesASCII(string name)
        {
            int sumOfCharecters = 0;
            foreach (var charecter in name)
            {
                sumOfCharecters += charecter;
            }
            return sumOfCharecters;
        }
    }
}
