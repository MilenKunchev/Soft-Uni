using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            char tempVariable = firstLetter;
            firstLetter = thirdLetter;
            thirdLetter = tempVariable;

            Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");

        }
    }
}
