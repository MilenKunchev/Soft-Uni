using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> processedData = Console.ReadLine().Split().ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] commandParameters = command.Split();

                if (commandParameters[0] == "merge")
                {
                    int startIndex = int.Parse(commandParameters[1]);
                    int endIndex = int.Parse(commandParameters[2]);
                    processedData = Merge(processedData, startIndex, endIndex);
                }
                else if (commandParameters[0] == "divide")
                {
                    int index = int.Parse(commandParameters[1]);
                    int partitions = int.Parse(commandParameters[2]);
                    processedData = Divide(processedData, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ",processedData));
        }

        // Divide method
        private static List<string> Divide(List<string> processedData, int index, int partitions)
        {
            string element = processedData[index];
            int partitionsLength = element.Length / partitions;

            List<string> devidedElement = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    devidedElement.Add(element.Substring(i * partitionsLength));
                }
                else
                {
                    devidedElement.Add(element.Substring(i * partitionsLength, partitionsLength));
                }
            }

            processedData.RemoveAt(index);
            processedData.InsertRange(index, devidedElement);

            return processedData;
        }

        // Merge method
        private static List<string> Merge(List<string> processedData, int startIndex, int endIndex)
        {
            //validate indexes
            startIndex = ValidateIndexes(startIndex, processedData.Count);
            endIndex = ValidateIndexes(endIndex, processedData.Count);
            //Merge..

            List<string> result = new List<string>();
            for (int i = 0; i < startIndex; i++)
            {
                result.Add(processedData[i]);
            }

            List<string> elementsToBeMerge = new List<string>();
            for (int i = startIndex; i <= endIndex; i++)
            {
                elementsToBeMerge.Add(processedData[i]);
            }

            StringBuilder mergedElements = new StringBuilder();
            foreach (var element in elementsToBeMerge)
            {
                mergedElements.Append(element);
            }

            result.Add(mergedElements.ToString());

            for (int i = endIndex + 1; i < processedData.Count; i++)
            {
                result.Add(processedData[i]);
            }

            return result;
        }

        private static int ValidateIndexes(int index, int maxlength)
        {
            if (index < 0)
            {
                index = 0;
            }
            if (index >= maxlength)
            {
                index = maxlength - 1;
            }
            return index;
        }
    }
}
