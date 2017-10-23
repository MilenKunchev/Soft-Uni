using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'p';        //wrong 'p'
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == Search)
            {
                hasMatch = true;

                int endIndex = jump + 1;      //+1 add

                if (endIndex > text.Length - i)       //-i add
                {
                    endIndex = text.Length - i;       //-i add

                }
                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += jump;

            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
