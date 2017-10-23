using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldАndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int kValue = arrayOfNums.Length / 4;
            // Create array "firstRow" of first and last "k" elements, reversed
            int[] firstRow = GetFirstRow(arrayOfNums, kValue);
            // create array "secondRow" of midle elements
            int[] secondRow = GetMidleRow(arrayOfNums, kValue);

            Console.WriteLine(string.Join(" ", SumRows(firstRow, secondRow)));
        }

        private static int[] SumRows(int[] firstRow, int[] secondRow)
        {
            var sumOfRows = new int[firstRow.Length];
            for (int i = 0; i < firstRow.Length; i++)
            {
                sumOfRows[i] = firstRow[i] + secondRow[i];
            }
            return sumOfRows;
        }

        private static int[] GetMidleRow(int[] arrayOfNums, int kValue)
        {
            var row = new int[kValue * 2];
            for (int i = 0; i < row.Length; i++)
            {
                row[i] = arrayOfNums[i + kValue];
            }
            return row;
        }

        private static int[] GetFirstRow(int[] arrayOfNums, int kValue)
        {
            var row = new int[kValue * 2];
            int lastPositionMinimize = 0;
            for (int i = 0; i < row.Length; i++)
            {
                if ((kValue - i - 1) >= 0)
                {
                    row[i] = arrayOfNums[kValue - i - 1];
                }
                if (i > kValue - 1)
                {
                    row[i] = arrayOfNums[arrayOfNums.Length - 1 - lastPositionMinimize];
                    lastPositionMinimize++;
                }
            }
            return row;
        }
    }
}
