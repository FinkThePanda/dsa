try
{
    Check.Equal("wertf", Solution.Solve(new[] {"wrt", "wrf", "er", "ett", "rftt"}));
    Check.Equal("", Solution.Solve(new[] {"abc", "ab"}));
    Check.Equal("", Solution.Solve(new[] {"z", "x", "z"}));
    Check.Equal("z", Solution.Solve(new[] {"z", "z"}));
    Check.Sequence(new[] {'a', 'b', 'c'}, Solution.Solve(new[] {"abc"}).OrderBy(c => c));
    Console.WriteLine("PASS: alien-dictionary");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement alien-dictionary in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
