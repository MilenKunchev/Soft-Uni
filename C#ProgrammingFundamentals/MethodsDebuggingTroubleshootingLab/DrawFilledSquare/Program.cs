using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderLine(n * 2);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintBodyLines(n);
            }
            PrintFooterLine(n * 2);


        }

        private static void PrintFooterLine(int countOfDashes)
        {
            Console.WriteLine(new string('-', countOfDashes));
        }

        private static void PrintBodyLines(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintHeaderLine(int countOfDashes)
        {
            Console.WriteLine(new string('-', countOfDashes));
        }
    }
}
