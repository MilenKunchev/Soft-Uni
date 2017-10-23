using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());
            var dayOfWeek = new string[8] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Invalid Day!" };
            Console.WriteLine(dayNumber < 8 && dayNumber > 0 ? dayOfWeek[dayNumber - 1] : dayOfWeek[7]);
        }
    }
}
