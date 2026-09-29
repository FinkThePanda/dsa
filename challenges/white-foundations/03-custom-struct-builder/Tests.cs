try
{
    Point original = Solution.Solve(3, -2);
    Check.Equal(3, original.X); Check.Equal(-2, original.Y);
    Point copy = original; copy.X = 99; Check.Equal(3, original.X);
    Console.WriteLine("PASS: custom-struct-builder");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement custom-struct-builder in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
