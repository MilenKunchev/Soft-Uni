using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int priceOfjewels = prices[0];
            int priceOfGold = prices[1];
            bool jailTime = false;
            long profit = 0;
            while (!jailTime)
            {
                string[] lootAndExpensesInfo = Console.ReadLine().Split(' ').ToArray();
                if (lootAndExpensesInfo[0] == "Jail" && lootAndExpensesInfo[1] == "Time")
                {
                    jailTime = true;
                }
                else
                {
                    profit += Calculate(lootAndExpensesInfo, priceOfjewels, priceOfGold);
                }


            }
            if (profit >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {profit}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(profit)}.");
            }
        }

        private static long Calculate(string[] lootAndExpensesInfo, int priceOfjewels, int priceOfGold)
        {

            int income = 0;
            char jewels = '%';
            char gold = '$';
            string loot = lootAndExpensesInfo[0];
            for (int i = 0; i < loot.Length; i++)
            {
                char lootElement = loot[i];
                if (lootElement == jewels)
                {
                    income += priceOfjewels;
                }
                else if (lootElement == gold)
                {
                    income += priceOfGold;
                }
            }
            long xpenses = int.Parse(lootAndExpensesInfo[1]);
            long profit = income - xpenses;
            return profit;
        }
    }
}
