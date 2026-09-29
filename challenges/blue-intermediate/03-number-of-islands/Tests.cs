try
{
    Check.Equal(3, Solution.Solve(new[] {"11000".ToCharArray(), "11000".ToCharArray(), "00100".ToCharArray(), "00011".ToCharArray()}));
    Check.Equal(0, Solution.Solve(Array.Empty<char[]>()));
    Check.Equal(2, Solution.Solve(new[] {"10".ToCharArray(), "01".ToCharArray()}));
    Console.WriteLine("PASS: number-of-islands");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement number-of-islands in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
