using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //day-month-year
            var input = Console.ReadLine();
            string format = "d-M-yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            var result = DateTime.ParseExact(input, format, provider);
            Console.WriteLine(result.DayOfWeek);


        }
    }
}
