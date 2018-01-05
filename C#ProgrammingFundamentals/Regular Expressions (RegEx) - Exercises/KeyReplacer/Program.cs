using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();

            string pattern = @"([a-zA-Z]+)(\\|\<|\|)(.?.*)(\\|\<|\|)([a-zA-Z]+)";
            string startString = string.Empty;
            string endString = string.Empty;

            foreach (Match keys in Regex.Matches(keyString, pattern))
            {
                startString = keys.Groups[1].ToString();
                endString = keys.Groups[5].ToString();
            }

            pattern = @"(" + startString + @"(.{0,}?)" + endString + @")";
            StringBuilder outputText = new StringBuilder();
            foreach (Match text in Regex.Matches(textString, pattern))
            {
                outputText.Append(text.Groups[2]);
            }
            if (outputText.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(outputText);
            }

        }
    }
}
