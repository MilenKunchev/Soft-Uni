using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string geometryFigureType = Console.ReadLine();
            double result = 0;
            switch (geometryFigureType)
            {
                case "triangle":
                    double sideA = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    result = CalculateTriangleArea(sideA, height);
                    break;
                case "square":
                    sideA = double.Parse(Console.ReadLine());
                    result = CalculateSquareArea(sideA);
                    break;
                case "rectangle":
                    sideA = double.Parse(Console.ReadLine());
                    double sideB = double.Parse(Console.ReadLine());
                    result = CalculateRectangeArea(sideA, sideB);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    result = CalculateCircleArea(radius);
                    break;
            }
            Console.WriteLine($"{result:f2}");

        }

        private static double CalculateTriangleArea(double sideA, double height)
        {
            return (sideA * height) / 2;
        }

        private static double CalculateSquareArea(double sideA)
        {
            return sideA * sideA;
        }

        private static double CalculateRectangeArea(double sideA, double sideB)
        {
            return sideA * sideB;
        }

        private static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
