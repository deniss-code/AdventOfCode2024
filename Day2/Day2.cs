using System.IO;

class Day2
{
    static bool IsSafe(int[] levels)
    {
        bool increasing = levels[1] > levels[0];

        for (int i = 1; i < levels.Length; i++)
        {
            int diff = Math.Abs(levels[i] - levels[i - 1]);
            if (diff == 0 || diff > 3)
            {
                return false;
            }

            if (increasing && levels[i] < levels[i - 1])
            {
                return false;
            }

            if (!increasing && levels[i] > levels[i - 1])
            {
                return false;
            }
        }

        return true;
    }

    static bool isSafeWithOneBad(int[] levels)
    {
        for (int removeIndex = 0; removeIndex < levels.Length; removeIndex++)
        {
            int[] modifiedNumbers = new int[levels.Length - 1];
            int j = 0;

            for (int i = 0; i < levels.Length; i++)
            {
                if (i != removeIndex)
                {
                    modifiedNumbers[j] = levels[i];
                    j++;
                }
            }

            if (IsSafe(modifiedNumbers))
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        string[] lines = File.ReadAllLines("C:/Users/cluni/Documents/Coding/AdventOfCode2024/Day2/input.txt");
        int partOneSafeCount = 0;
        int partTwoSafeCount = 0;


        foreach (string line in lines)
        {
            string[] values = line.Split(' ');
            int[] levels = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                levels[i] = int.Parse(values[i]);
            }


            if (IsSafe(levels))
            {
                partOneSafeCount++;
            }

            if (IsSafe(levels) || isSafeWithOneBad(levels))
            {
                partTwoSafeCount++;
            }




        }
        Console.WriteLine($"First Task: {partOneSafeCount}");
        Console.WriteLine($"Second Task: {partTwoSafeCount}");
    }
}