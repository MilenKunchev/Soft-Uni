using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            List<SnowBall> snowBalls = new List<SnowBall>();

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                SnowBall anySnowball = new SnowBall();

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int divideResult = snowballSnow / snowballTime;
                BigInteger snowballValue = BigInteger.Pow(divideResult, snowballQuality);
                //(snowballSnow / snowballTime) ^ snowballQuality

                anySnowball.SnowballSnow = snowballSnow;
                anySnowball.SnowballTime = snowballTime;
                anySnowball.SnowballQuality = snowballQuality;
                anySnowball.SnowballValue = snowballValue;

                snowBalls.Add(anySnowball);
            }

            var first = snowBalls.OrderByDescending(x => x.SnowballValue).First();

            Console.WriteLine($"{first.SnowballSnow} : {first.SnowballTime} =" +
                $" {first.SnowballValue} ({first.SnowballQuality})");
        }

        class SnowBall
        {
            public int SnowballSnow { get; set; }
            public int SnowballTime { get; set; }
            public int SnowballQuality { get; set; }
            public BigInteger SnowballValue { get; set; }
        }
    }
}
