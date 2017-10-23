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
            var num = decimal.Parse(Console.ReadLine());

            //var reversedNum = ReverseNumDigits(num);
            Console.WriteLine(ReverseNumDigits(num));


        }

        private static decimal ReverseNumDigits(decimal num)
        {
            var numToString = num.ToString();
            var result = string.Empty;
            for (int i = numToString.Length - 1; i >= 0; i--)
            {
                result += numToString[i];
            }
            return decimal.Parse(result);
        }
    }
}
