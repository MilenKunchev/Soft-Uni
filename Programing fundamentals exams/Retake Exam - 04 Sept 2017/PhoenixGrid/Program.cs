namespace PhoenixGrid
{
    using System;
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([^\s_]{3}[.])*[^\s_]{3}$";
            string input = Console.ReadLine();

            while (input != "ReadMe")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success && IsPalindrome(input))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
