using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            List<decimal> newNumbers = new List<decimal>();
            bool equalNumbers = true;

            while (equalNumbers)
            {
                decimal sum = 0m;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i < numbers.Count - 1 && numbers[i] == numbers[i + 1])
                    {
                        sum = numbers[i] + numbers[i + 1];
                        newNumbers.Add(sum);
                        i++;
                    }
                    else
                    {
                        newNumbers.Add(numbers[i]);
                    }
                }
                numbers.Clear();
                for (int i = 0; i < newNumbers.Count; i++)
                {
                    numbers.Add(newNumbers[i]);
                }
                newNumbers.Clear();
                if (sum == 0)
                {
                    equalNumbers = false;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
