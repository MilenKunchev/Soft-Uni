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
            List<Directory> directories = new List<Directory>();

            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                string[] inputData = Console.ReadLine().Split(new char[] { '\\', ';' }).ToArray();

                string root = inputData[0];
                string fileName = inputData[inputData.Length - 2];
                long fileSize = long.Parse(inputData[inputData.Length - 1]);
                string fileExtension = fileName.Split(new char[] { '.' }).ToArray().Last();

                //Directory doesn't exist  , add new directory , new filename, extension and size
                if (!directories.Any(x => x.Name == root))
                {
                    Directory currentDirectory = new Directory(root);
                    File currentFile = new File(fileName, fileExtension, fileSize);

                    currentDirectory.Files.Add(currentFile);
                    directories.Add(currentDirectory);
                }

                // Directory exist
                else if (directories.Any(x => x.Name == root))
                {
                    Directory currentDirectory = directories.First(x => x.Name == root);

                    // If file name exist , add new file size
                    if (currentDirectory.Files.Any(x => x.Name == fileName))
                    {
                        File currentFile = currentDirectory.Files.First(x => x.Name == fileName);

                        currentFile.Size = fileSize;
                    }

                    // if file name  doesn't exist , add new filename, extension and size
                    else
                    {
                        File currentFile = new File(fileName, fileExtension, fileSize);
                        currentDirectory.Files.Add(currentFile);
                    }
                }
            }

            string[] wantedData = Console.ReadLine().Split().ToArray();
            string wantedExtension = wantedData[0];
            string wantedRoot = wantedData.Last();

            
            bool haveMatch = false;
            // Find wanted root
            if (directories.Any(x => x.Name == wantedRoot))
            {
                Directory currentRoot = directories.First(n => n.Name == wantedRoot);

                // Find wanted file extension and sort
                foreach (var file in currentRoot.Files.Where(x => x.Extension == wantedExtension)
                    .OrderByDescending(x => x.Size)
                    .ThenBy(x => x.Name))
                {
                    Console.WriteLine($"{file.Name} - {file.Size} KB");

                    haveMatch = true;
                }
            }

            if (!haveMatch)
            {
                Console.WriteLine("No");
            }
        }

        class Directory
        {
            public string Name { get; set; }
            public List<File> Files { get; set; }

            public Directory(string name)
            {
                this.Name = name;
                this.Files = new List<File>();
            }
        }

        class File
        {
            public string Name { get; set; }
            public string Extension { get; set; }
            public long Size { get; set; }

            public File(string name, long size)
            {
                this.Name = name;
                this.Size = size;
            }

            public File(string name, string extension, long size)
            {
                this.Name = name;
                this.Extension = extension;
                this.Size = size;
            }
        }
    }
}
