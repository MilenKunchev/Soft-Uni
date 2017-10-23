using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} -> {CheckForSpecialNum(i)}");
            }
        }

        static bool CheckForSpecialNum(int number)
        {
            int sum = 0;
            int splitNumber = 0;
            while (number != 0)
            {
                splitNumber = number % 10;
                sum += splitNumber;
                number /= 10;
            }
            return (sum == 5 || sum == 7 || sum == 11);


        }
    }
}
