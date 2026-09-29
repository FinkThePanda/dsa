// public static class Solution
// {
//     public static int Solve(int[] numbers)
//         => throw new NotImplementedException("Your turn: implement this exercise.");
// }

using System;

public static class Solution
{
    public static int Solve(int[] numbers)
    {
        // return if numbers is null or empty
        if (numbers == null)
            return 0;

        // start off by setting result to first int in array
        int result = numbers[0];

        // skip [0] - is set above
        for (int i = 1; i < numbers.Length; i++)
        {
            // if number in array is larger than result, then replace
            if (numbers[i] > result)
                result = numbers[i];
        }

        return result;
    }

    public static int Main()
    {       
        // Test cases
        int[] test1 = [2, 9, 1];
        int[] test2 = [-8, -2, -9];
        int[] test3 = [7];

        Console.WriteLine(Solve(test1)); // 9
        Console.WriteLine(Solve(test2)); // -2
        Console.WriteLine(Solve(test3)); // 7

        return 0;
    }
}