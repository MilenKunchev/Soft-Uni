using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> directories = new Dictionary<string, Dictionary<string, long>>();

            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                string[] inputData = Console.ReadLine().Split(new char[] { '\\', ';' }).ToArray();

                string root = inputData[0];
                string fileName = inputData[inputData.Length - 2];
                long fileSize = long.Parse(inputData[inputData.Length - 1]);
                string fileExtension = fileName.Split(new char[] { '.' }).ToArray().Last();

                if (!directories.ContainsKey(root))
                {
                    directories[root] = new Dictionary<string, long>();
                    directories[root][fileName] = fileSize;
                }
                else
                {
                    directories[root][fileName] = fileSize;
                }
            }

            string[] wantedData = Console.ReadLine().Split().ToArray();
            string wantedExtension = wantedData[0];
            string wantedRoot = wantedData.Last();

            Dictionary<string, long> wantedFileAndSize = new Dictionary<string, long>();
            bool haveFiles = false;

            if (directories.ContainsKey(wantedRoot))
            {
                wantedFileAndSize = directories[wantedRoot];
            }

            foreach (var file in wantedFileAndSize
                .Where(x => x.Key.Split('.').Last() == wantedExtension)
                .OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{file.Key} - {file.Value} KB");
                haveFiles = true;
            }

            if (!haveFiles)
            {
                Console.WriteLine("No");
            }
        }
    }
}
