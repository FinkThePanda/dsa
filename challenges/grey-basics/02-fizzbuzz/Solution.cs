// public static class Solution
// {
//     public static string[] Solve(int n)
//         => throw new NotImplementedException("Your turn: implement this exercise.");
// }


using System;

public static class Solution
{
    public static string[] Solve(int n)
    {
        if (n < 0)
            return Array.Empty<string>();

        string[] result = new string[n];

        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
                result[i - 1] = "FizzBuzz";
            else if (i % 3 == 0)
                result[i - 1] = "Fizz";
            else if (i % 5 == 0)
                result[i - 1] = "Buzz";
            else
                result[i - 1] = i.ToString();
        }

        return result;
    }

    public static int Main()
    {
        int n = 15;
        
        Console.WriteLine(string.Join(", ", Solve(n)));
        
        return 0;
    }
}