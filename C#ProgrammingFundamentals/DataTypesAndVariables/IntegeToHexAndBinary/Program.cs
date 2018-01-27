using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegeToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string hexadecimal = Convert.ToString(input, 16).ToUpper();
            string binary = Convert.ToString(input, 2);

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);


        }
    }
}
