try
{
    Check.Equal(2, Solution.Solve(new[] {1, 3, 5, 7}, 5));
    Check.Equal(0, Solution.Solve(new[] {1, 3, 5}, 1));
    Check.Equal(-1, Solution.Solve(new[] {1, 3, 5}, 2));
    Check.Equal(-1, Solution.Solve(Array.Empty<int>(), 2));
    Console.WriteLine("PASS: binary-search");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement binary-search in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
