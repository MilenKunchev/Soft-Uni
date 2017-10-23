using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetTriangleArea(width, height));

        }

        private static double GetTriangleArea(double width, double height)
        {
            double area = (width * height) / 2;
            return area;
        }
    }
}
