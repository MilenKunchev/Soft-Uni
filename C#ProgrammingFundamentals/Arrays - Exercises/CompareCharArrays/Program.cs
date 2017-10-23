using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool firstArrayIsShorter = true;
            if (firstCharArray.Length > secondCharArray.Length)
            {
                firstArrayIsShorter = false;
            }
            if (firstCharArray.Length == secondCharArray.Length)
            {
                // first array length = second array length return true if first Array Is Shorter
                firstArrayIsShorter = DoAlphabeticalVerification(firstCharArray, secondCharArray);
            }
            if (firstArrayIsShorter)
            {
                Console.WriteLine(firstCharArray);
                Console.WriteLine(secondCharArray);
            }
            else
            {
                Console.WriteLine(secondCharArray);
                Console.WriteLine(firstCharArray);
            }
        }

        private static bool DoAlphabeticalVerification(char[] firstCharArray, char[] secondCharArray)
        {
            bool firstArrayIsShorter = true;
            for (int i = 0; i < firstCharArray.Length; i++)
            {
                firstArrayIsShorter = firstCharArray[i] < secondCharArray[i];
            }
            return firstArrayIsShorter;
        }
    }
}
