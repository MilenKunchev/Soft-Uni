using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayОfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ').ToArray();
            string [] reverset = arrayOfStrings.Reverse().ToArray();            
            Console.WriteLine(string.Join(" ", reverset));
        }
    }
}
