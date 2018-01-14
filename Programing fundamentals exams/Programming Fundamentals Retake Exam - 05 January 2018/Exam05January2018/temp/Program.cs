using System;
using System.Collections.Generic;
using System.Linq;

class Snowmen
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        while (nums.Count > 1)
        {
            HashSet<int> losers = new HashSet<int>();

            Traverse(nums, losers);
            RemoveLosers(ref nums, losers);
        }
    }

    private static void RemoveLosers(ref List<int> nums, HashSet<int> losers)
    {
        foreach (var loser in losers)
        {
            nums[loser] = -1;
        }

        nums = nums.Where(n => n != -1).ToList();
    }

    private static void Traverse(List<int> nums, HashSet<int> losers)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums.Count - losers.Count == 1)
                break;

            int attackerIndex = i;
            int targetIndex = FindTargetIndex(nums, attackerIndex);

            if (losers.Contains(attackerIndex))
                continue;

            int diff = Math.Abs(attackerIndex - targetIndex);

            if (diff == 0)
            {
                Console.WriteLine($"{attackerIndex} performed harakiri");
                losers.Add(attackerIndex);
            }
            else if (diff % 2 == 0)
            {
                Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                losers.Add(targetIndex);
            }
            else if (diff % 2 != 0)
            {
                Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                losers.Add(attackerIndex);
            }
        }
    }

    private static int FindTargetIndex(List<int> nums, int attackerIndex)
    {
        int attacker = nums[attackerIndex];
        return attacker >= nums.Count ? attacker % nums.Count : attacker;
    }
}