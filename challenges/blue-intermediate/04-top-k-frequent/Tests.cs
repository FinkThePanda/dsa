try
{
    Check.Sequence(new[] {1, 2}, Solution.Solve(new[] {1, 1, 1, 2, 2, 3}, 2).OrderBy(x => x));
    Check.Sequence(new[] {2}, Solution.Solve(new[] {3, 2, 3, 2}, 1));
    Check.Sequence(Array.Empty<int>(), Solution.Solve(new[] {1}, 0));
    Console.WriteLine("PASS: top-k-frequent");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement top-k-frequent in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
