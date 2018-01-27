using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numA = Console.ReadLine().Split('.').ToArray();
            string[] numB = Console.ReadLine().Split('.').ToArray();

            string numALeftPart = numA[0];
            string numARightPart = numA[1];

            string numBLeftPart = numB[0];
            string numBRightPart = numB[1];

            numARightPart = GetFirstSixElementOFNum(numARightPart);
            numBRightPart = GetFirstSixElementOFNum(numBRightPart);

            bool isEqualLeftPart = int.Parse(numALeftPart) == int.Parse(numBLeftPart);
            bool isEqualRightPart = int.Parse(numARightPart) == int.Parse(numBRightPart);

            if (isEqualLeftPart && isEqualRightPart)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private static string GetFirstSixElementOFNum(string num)
        {
            if (num.Length > 6)
            {
                string numWithSixDidgits = string.Join("", num.Take(6));
                return numWithSixDidgits;
            }
            else
            {
                return num;
            }
        }
    }
}
