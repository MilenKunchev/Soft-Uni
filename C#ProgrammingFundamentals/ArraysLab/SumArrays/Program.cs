using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxArrayLength = Math.Max(array1.Length, array2.Length);
            var arraySum = new int[maxArrayLength];
            for (int i = 0; i < maxArrayLength; i++)
            {
                arraySum[i] = array1[i % array1.Length] + array2[i % array2.Length];
            }
            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}
