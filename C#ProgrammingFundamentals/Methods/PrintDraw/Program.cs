using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooterLine(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintBodyLain(n);
            }
            PrintHeaderFooterLine(n);
        }

         static void PrintBodyLain(int n)
        {
            throw new NotImplementedException();
        }

         static void PrintHeaderFooterLine(int n)
        {
            Console.WriteLine(new string ('-',n));
        }
    }
}
