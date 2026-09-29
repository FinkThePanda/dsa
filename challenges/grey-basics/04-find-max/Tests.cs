try
{
    Check.Equal(9, Solution.Solve(new[] {2, 9, 1}));
    Check.Equal(-2, Solution.Solve(new[] {-8, -2, -9}));
    Check.Equal(7, Solution.Solve(new[] {7}));
    Console.WriteLine("PASS: find-max");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement find-max in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
