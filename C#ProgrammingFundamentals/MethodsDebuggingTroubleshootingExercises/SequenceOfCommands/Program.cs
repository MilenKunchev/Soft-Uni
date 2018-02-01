using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    public static void Main()
    {
        int countOfNumbers = int.Parse(Console.ReadLine());

        long[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();

        string[] command = Console.ReadLine().Split().ToArray();

        while (command[0] != "stop") // "over" -> "stop"
        {
            PerformAction(ref numbers, command);

            Console.WriteLine(string.Join(" ", numbers));

            command = Console.ReadLine().Split().ToArray();
        }

    }

    static void PerformAction(ref long[] numbers, string[] command)
    {
        int pos = 0;
        int value = 0;

        if (command.Length > 1)
        {
            pos = int.Parse(command[1]);
            value = int.Parse(command[2]);
        }
        switch (command[0])
        {
            case "multiply":
                numbers[pos - 1] *= value;
                break;
            case "add":
                numbers[pos - 1] += value;
                break;
            case "subtract":
                numbers[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(ref numbers);
                break;
            case "rshift":
                ArrayShiftRight(ref numbers);
                break;
        }
    }

    private static void ArrayShiftRight(ref long[] array)
    {
        long[] tempArray = new long[array.Length];
        long lastNum = array[array.Length - 1];
        tempArray[0] = lastNum;
        for (int i = 0; i < array.Length - 1; i++)
        {
            tempArray[i + 1] = array[i];
        }
        array = tempArray;
    }

    private static void ArrayShiftLeft(ref long[] array)
    {
        long[] tempArray = new long[array.Length];
        long firstNum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            tempArray[i - 1] = array[i];
        }
        tempArray[tempArray.Length - 1] = firstNum;
        array = tempArray;
    }
}
