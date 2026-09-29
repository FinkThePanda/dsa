try
{
    var edges = new (int, int, int)[] {(0, 1, 4), (0, 2, 1), (2, 1, 2), (1, 3, 1)};
    Check.Sequence(new long[] {0, 3, 1, 4, long.MaxValue}, Solution.Solve(5, edges, 0));
    Check.Sequence(new long[] {0}, Solution.Solve(1, Array.Empty<(int, int, int)>(), 0));
    Console.WriteLine("PASS: dijkstra");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement dijkstra in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
