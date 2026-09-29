try
{
    Check.Equal(1, Solution.Solve(0));
    Check.Equal(2, Solution.Solve(2));
    Check.Equal(8, Solution.Solve(5));
    Check.Equal(1836311903, Solution.Solve(45));
    Console.WriteLine("PASS: climbing-stairs");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement climbing-stairs in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
