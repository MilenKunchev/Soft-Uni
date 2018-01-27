using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int totalSum = 0;
            int combinationCounter = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (totalSum >= maxSum)
                    {
                        break;
                    }
                    //Multiply the two digits, then multiply their product by 3. Add the result to the total sum. 
                    totalSum += (i * j) * 3;
                    combinationCounter++;
                }
            }

            if (totalSum >= maxSum)
            {
                Console.WriteLine($"{combinationCounter} combinations");
                Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{combinationCounter} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}
