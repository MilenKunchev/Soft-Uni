using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMaxInteger(first, second));
            }
            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMaxChar(first, second));
            }
            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMaxString(first, second));
            }
        }

        static int GetMaxInteger(int first, int second)
        {
            int max = Math.Max(first, second);
            return max;
        }

        static char GetMaxChar(char first, char second)
        {
            int max = Math.Max(first, second);
            return (char)max;
        }

        static string GetMaxString(string firs, string second)
        {
            string max;
            if (firs.CompareTo(second) >= 0)
            {
                max = firs;
            }
            else
            {
                max = second;
            }
            return max;
        }
    }
}
