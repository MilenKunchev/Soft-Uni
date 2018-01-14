using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace temp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            var placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Regex regex = new Regex(@"([a-zA-Z]+)(.*)(\1)");

            MatchCollection matches = regex.Matches(encodedText);

            int matchesCount = 0;
            int placeholderPosition = 0;
            int corectionPosition = 0;

            foreach (Match match in matches)
            {

                if (matchesCount >= placeholders.Count) break;

                string oldValue = match.Groups[2].ToString();
                string newValue = placeholders[placeholderPosition];

                int matchIndex = match.Groups[2].Index;
                int matchLength = match.Groups[2].Length;

                string leftpart = encodedText.Substring(0, matchIndex + corectionPosition);

                string leftPartAndNewValue = leftpart + newValue;

                string allTextWithNewValue = leftPartAndNewValue + encodedText.Substring(matchIndex + matchLength + corectionPosition);

                corectionPosition = allTextWithNewValue.Length - encodedText.Length;

                encodedText = allTextWithNewValue;

                matchesCount++;
                placeholderPosition++;
            }

            Console.WriteLine(encodedText);
        }
    }
}
