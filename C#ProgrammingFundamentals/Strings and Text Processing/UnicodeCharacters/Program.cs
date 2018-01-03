using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var character in input)
            {
                int asci = (int)character;
                Console.Write("\\u{0:x4}", asci);
            }
            Console.WriteLine();
        }
    }
}
