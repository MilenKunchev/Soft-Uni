using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                Point currentPoint = Point.ParcePoint(Console.ReadLine());
                points.Add(currentPoint);
            }
            double minDistance = double.MaxValue;
            Point[] bestTwoPoints = new Point[2];

            for (int prevPoint = 0; prevPoint < points.Count; prevPoint++)
            {
                for (int currentPoint = prevPoint+1; currentPoint < points.Count; currentPoint++)
                {
                    double distance = CalcDistance(points[prevPoint], points[currentPoint]);
                    if (distance<minDistance)
                    {
                        minDistance = distance;
                        bestTwoPoints[0] = points[prevPoint];
                        bestTwoPoints[1] = points[currentPoint];
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({bestTwoPoints[0].X}, {bestTwoPoints[0].Y})");
            Console.WriteLine($"({bestTwoPoints[1].X}, {bestTwoPoints[1].Y})");
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
