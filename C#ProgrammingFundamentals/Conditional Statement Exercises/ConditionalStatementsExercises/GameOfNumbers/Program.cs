using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int lastCombinationFirstNum = 0;
            int lastCombinationSecondNum = 0;
            int combinationsCounter = 0;

            bool existMagicNumber = false;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    if (i + j == magicNum)
                    {
                        lastCombinationFirstNum = i;
                        lastCombinationSecondNum = j;
                        existMagicNumber = true;
                    }
                    combinationsCounter++;
                }
            }
            if (existMagicNumber)
            {
                Console.WriteLine($"Number found! {lastCombinationFirstNum} + {lastCombinationSecondNum} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicNum}");
            }
        }
    }
}
