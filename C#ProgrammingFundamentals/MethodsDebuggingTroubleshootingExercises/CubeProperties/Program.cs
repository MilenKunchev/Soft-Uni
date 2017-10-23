using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfTheCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0.0;
            switch (parameter)
            {
                case "face":
                    result = CalculateFace(sideOfTheCube);
                    break;
                case "space":
                    result = CalculateSpace(sideOfTheCube);
                    break;
                case "volume":
                    result = CalculateVolume(sideOfTheCube);
                    break;
                case "area":
                    result = CalculateArea(sideOfTheCube);
                    break;
            }
            PrintREsult(result);

        }

        static void PrintREsult(double result)
        {
            Console.WriteLine($"{result:f2}");
        }

        private static double CalculateVolume(double sideOfTheCube)
        {
            return Math.Pow(sideOfTheCube, 3);
        }

        private static double CalculateArea(double sideOfTheCube)
        {
            return 6 * Math.Pow(sideOfTheCube, 2);
        }

        private static double CalculateSpace(double sideOfTheCube)
        {
            return Math.Sqrt(3 * Math.Pow(sideOfTheCube,2));
        }

        private static double CalculateFace(double sideOfTheCube)
        {
            return Math.Sqrt(2) * sideOfTheCube;
        }
    }
}
