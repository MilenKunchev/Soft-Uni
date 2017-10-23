

namespace BackIn30Minutes
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            if (minutes >= 60)
            {
                hours++;
                if (hours == 24)
                {
                    hours = 0;
                }
                minutes -= 60;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
