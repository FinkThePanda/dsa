try
{
    int[] a = {2, 7, 11, 15}; var r = Solution.Solve(a, 9);
    Check.Equal(2, r.Length); Check.Equal(true, r[0] != r[1]); Check.Equal(9, a[r[0]] + a[r[1]]);
    Check.Sequence(new[] {0, 1}, Solution.Solve(new[] {3, 3}, 6).OrderBy(x => x));
    Console.WriteLine("PASS: two-sum");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement two-sum in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
