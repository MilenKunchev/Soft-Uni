using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {

            Point point1 = Point.ParcePoint(Console.ReadLine());
            Point point2 = Point.ParcePoint(Console.ReadLine());

            double distance = CalcDistance(point1, point2);
            Console.WriteLine($"{distance:f3}");
            
            
        }

        private static double CalcDistance(Point point1, Point point2)
        {
            double sideA = Math.Pow((point1.X - point2.X), 2);
            double sideB = Math.Pow((point1.Y - point2.Y), 2);
            return Math.Sqrt(sideA + sideB);
        }

        class Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public static Point ParcePoint(string input)
            {
                int[] inputXY = input.Split().Select(int.Parse).ToArray();
                return new Point(inputXY[0], inputXY[1]);
            }
        }
    }
}
