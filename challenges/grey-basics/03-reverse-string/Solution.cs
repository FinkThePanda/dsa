// public static class Solution
// {
//     public static string Solve(string text)
//         => throw new NotImplementedException("Your turn: implement this exercise.");
// }

using System;

public static class Solution
{
    public static string Solve(string s)
    {
        // Turn string into char array
        char[] charArray = s.ToCharArray();

        // Use build in array-reverse
        Array.Reverse(charArray);

        // Return the array as a string
        return new string(charArray);
    }

    public static int Main()
    {       
        // Test cases
        string test1 = "olleh";
        string test2 = "";
        string test3 = "!a b";

        Console.WriteLine($"Original: \"{test1}\" | Reversed: \"{Solve(test1)}\"");
        Console.WriteLine($"Original: \"{test2}\" | Reversed: \"{Solve(test2)}\"");
        Console.WriteLine($"Original: \"{test3}\" | Reversed: \"{Solve(test3)}\"");

        return 0;
    }
}