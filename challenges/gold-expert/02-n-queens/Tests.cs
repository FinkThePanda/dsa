try
{
    var solutions = Solution.Solve(4); Check.Equal(2, solutions.Length);
    Check.Equal(2, solutions.Select(x => string.Join(",", x)).Distinct().Count());
    foreach (var s in solutions) { Check.Equal(4, s.Length); for (int r = 0; r < 4; r++) { Check.Equal(true, s[r] >= 0 && s[r] < 4); for (int t = r + 1; t < 4; t++) { Check.Equal(true, s[r] != s[t]); Check.Equal(true, Math.Abs(s[r] - s[t]) != t - r); } } }
    Check.Equal(1, Solution.Solve(1).Length); Check.Equal(0, Solution.Solve(2).Length);
    Console.WriteLine("PASS: n-queens");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement n-queens in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
