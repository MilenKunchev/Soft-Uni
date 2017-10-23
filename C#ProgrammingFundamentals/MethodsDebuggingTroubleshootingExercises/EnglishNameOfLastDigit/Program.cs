using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string lastDigitInEnglish = ReturnLastDiginInEnglish(number);
            Console.WriteLine(lastDigitInEnglish);

        }

        private static string ReturnLastDiginInEnglish(string number)
        {

            string[] digitnames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int lastDigit = (int)char.GetNumericValue((number[number.Length - 1]));
            return digitnames[lastDigit];
        }
    }
}
