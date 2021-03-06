﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDays = int.Parse(Console.ReadLine());
            int numberOfRunners = int.Parse(Console.ReadLine());
            int numberOfLaps = int.Parse(Console.ReadLine());
            int lengthOfTheTrack = int.Parse(Console.ReadLine());
            int capacityOfTheTrack = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            long totalRunners = Math.Min(numberOfRunners, capacityOfTheTrack * marathonDays);
            long totalmeters = numberOfLaps * totalRunners * lengthOfTheTrack;
            long totalKilometers = totalmeters / 1000;
            decimal totalMoney = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
