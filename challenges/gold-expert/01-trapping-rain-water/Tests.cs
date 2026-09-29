try
{
    Check.Equal(6L, Solution.Solve(new[] {0,1,0,2,1,0,1,3,2,1,2,1}));
    Check.Equal(9L, Solution.Solve(new[] {4,2,0,3,2,5}));
    Check.Equal(0L, Solution.Solve(Array.Empty<int>()));
    Console.WriteLine("PASS: trapping-rain-water");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement trapping-rain-water in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
