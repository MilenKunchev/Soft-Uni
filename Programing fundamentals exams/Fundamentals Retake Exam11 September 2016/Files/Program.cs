using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //<root,<file name.ext,size>>()
            var files = new Dictionary<string, Dictionary<string, long>>();

            int numberOfInputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputLines; i++)
            {
                string[] fileDataAndRoot = Console.ReadLine()
                    .Split(new[] { '\\' })
                    .Select(x => x.Trim())
                    .ToArray();

                string root = fileDataAndRoot[0];
                string fileData = fileDataAndRoot[fileDataAndRoot.Length - 1];
                string[] fileNameAndSizeTokens = fileData.Split(new[] { ';' }).ToArray();
                string fileName = fileNameAndSizeTokens[0];
                long fileSize = long.Parse(fileNameAndSizeTokens[fileNameAndSizeTokens.Length - 1]);

                AddFileToDict(files, root, fileName, fileSize);
            }
            string[] searchedFiles = Console.ReadLine()
                .Split(new[] { " in " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string searchedRoot = searchedFiles[1];
            string searchedExtension = searchedFiles[0];

            var findedRoot = files.Where(x => x.Key == searchedRoot).ToDictionary(x => x.Key, x => x.Value);

            if (findedRoot.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                bool noFilesInRoot = true;
                foreach (var file in findedRoot[searchedRoot].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string fileExtension = file.Key.Split(new[] { '.' }).ToArray().Last();
                    if (fileExtension == searchedExtension)
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                        noFilesInRoot = false;
                    }
                }
                if (noFilesInRoot)
                {
                    Console.WriteLine("No");
                }
            }
        }

        private static void AddFileToDict(Dictionary<string, Dictionary<string, long>> files
            , string root, string fileName, long fileSize)
        {
            if (!files.ContainsKey(root))
            {
                files[root] = new Dictionary<string, long>();
                files[root][fileName] = fileSize;
            }
            else
            {
                files[root][fileName] = fileSize;
            }
        }
    }
}