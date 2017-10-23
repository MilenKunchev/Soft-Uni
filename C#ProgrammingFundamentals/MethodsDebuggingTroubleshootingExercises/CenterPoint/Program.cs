using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPointDistance = FindFirstPointDistance(x1, y1);
            double secondPointDistance = FindSecondPoindDistance(x2, y2);
            bool closerPoint = FindCloserPoint(firstPointDistance, secondPointDistance);

            if (closerPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double FindSecondPoindDistance(double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
        }

        private static double FindFirstPointDistance(double x1, double y1)
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }

        private static bool FindCloserPoint(double firstPointDistance, double secondPointDistance)
        {
            if (firstPointDistance <= secondPointDistance)
            {
                return true;
            }
            return false;
        }
    }
}
