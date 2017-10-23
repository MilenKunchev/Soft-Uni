using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumOfValues = 0;
            sumOfValues = GetSum(arrayOfIntegers);
            Console.WriteLine(sumOfValues);

        }

        private static int GetSum(int[] arrayOfIntegers)
        {
            int sum = arrayOfIntegers[0];
            int index = arrayOfIntegers[0];
            
            while ((index >= 0 && index < arrayOfIntegers.Length))
            {
                if (index < arrayOfIntegers.Length)
                {
                    sum += arrayOfIntegers[index];
                    if ((index+ arrayOfIntegers[index]) < arrayOfIntegers.Length)
                    {
                        index += arrayOfIntegers[index];
                    }
                    else
                    {
                        index -= arrayOfIntegers[index];
                    }
                }
                
            }


            return sum;
        }
    }
}
