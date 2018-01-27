using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {

            char start = (char)int.Parse(Console.ReadLine());
            char end = (char)int.Parse(Console.ReadLine());

            for (char i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
