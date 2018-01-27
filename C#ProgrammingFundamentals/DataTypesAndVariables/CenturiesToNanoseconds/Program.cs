using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            ulong days = (ulong)(years * 365.2422);
            ulong hours = 24 * days;
            ulong minutes = 60 * hours;
            ulong seconds = 60 * minutes;
            ulong milliseconds = 1000 * seconds;
            decimal microseconds = 1000 * milliseconds;
            decimal nanoseconds = 1000 * microseconds;

            Console.Write($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes}");
            Console.Write($" minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds}");
            Console.WriteLine($" microseconds = {nanoseconds} nanoseconds");



        }
    }
}
