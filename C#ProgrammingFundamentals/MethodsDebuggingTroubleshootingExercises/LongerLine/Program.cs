using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinatesList = new List<double>();
            for (int i = 0; i < 4; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                coordinatesList.Add(x);
                coordinatesList.Add(y);
            }
            PrintLongerLine(coordinatesList[0], coordinatesList[1], coordinatesList[2], coordinatesList[3],
                 coordinatesList[4], coordinatesList[5], coordinatesList[6], coordinatesList[7]);

        }

        private static void PrintLongerLine(double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4)
        {
            
            
        }

        
        private static double FindLongerLine(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}