using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Append_Lists
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();

            items.Reverse();
            List<string> result = new List<string>();
            result = RemoveEmptySpaces(items);
            Console.WriteLine(string.Join(" ", result));
        }

        private static List<string> RemoveEmptySpaces(List<string> items)
        {
            var noEmptySpaces = new List<string>();
            foreach (var item in items)
            {
                string[] elements = item.Split(' ');
                foreach (var element in elements)
                {
                    if (element != "")
                    {
                        noEmptySpaces.Add(element);
                    }
                }
            }
            return noEmptySpaces;

        }
    }
}