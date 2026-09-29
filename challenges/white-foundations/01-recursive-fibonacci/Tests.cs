try
{
    Check.Equal(0, Solution.Solve(0));
    Check.Equal(1, Solution.Solve(1));
    Check.Equal(55, Solution.Solve(10));
    Console.WriteLine("PASS: recursive-fibonacci");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement recursive-fibonacci in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
