using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerCounter = 0;
            while (true)
            {
                string input = Console.ReadLine();                

                bool isinteger = int.TryParse(input, out int number);

                if (isinteger)
                {
                    integerCounter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(integerCounter);
        }
    }
}
