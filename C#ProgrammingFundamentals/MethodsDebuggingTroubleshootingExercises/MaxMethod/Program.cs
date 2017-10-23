using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int theBiggestNumber = GetMax(firstNumber, secondNumber);            
            Console.WriteLine(Math.Max(theBiggestNumber, thirdNumber));
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            return Math.Max(firstNumber, secondNumber);
        }
    }
}
