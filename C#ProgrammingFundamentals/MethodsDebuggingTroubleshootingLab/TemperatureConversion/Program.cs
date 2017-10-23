using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            var celsius = FahrenheitToCelsisus(fahrenheit);
            Console.WriteLine($"{celsius:f2}");
        }

        static double FahrenheitToCelsisus(double fahrenheit)
        {

            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
