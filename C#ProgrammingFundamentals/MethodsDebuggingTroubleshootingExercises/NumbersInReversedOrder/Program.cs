using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            Console.WriteLine(ReverseNumDigits(num));
        }

        private static string ReverseNumDigits(string num)
        {
            var result = string.Empty;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                result += num[i];
            }
            return (result);
        }
    }
}
