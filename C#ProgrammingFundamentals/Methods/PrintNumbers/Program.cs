using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbers
{
    class Program
    {
        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
                
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = int.Parse(Console.ReadLine());
            PrintNumbers(start, end);
        }
    }
}
