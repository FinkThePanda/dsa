try
{
    int a = 3, b = -4;
    Solution.Solve(ref a, ref b);
    Check.Equal(-4, a); Check.Equal(3, b);
    a = 2; b = 2; Solution.Solve(ref a, ref b); Check.Equal(2, a); Check.Equal(2, b);
    Console.WriteLine("PASS: swap-variables");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement swap-variables in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
