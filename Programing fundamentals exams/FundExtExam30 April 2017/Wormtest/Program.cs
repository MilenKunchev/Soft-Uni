using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine()) * 100;
            double width = double.Parse(Console.ReadLine());

            if (width == 0)
            {
                Console.WriteLine($"{length * width:f2}");
            }
            else if (length % width == 0)
            {
                Console.WriteLine($"{length * width:f2}");
            }
            else
            {
                Console.WriteLine($"{(length / width) * 100:f2}%");
            }


        }
    }
}
