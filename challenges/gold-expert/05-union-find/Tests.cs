try
{
    Check.Equal(2, Solution.Solve(5, new (int, int)[] {(0,1), (1,2), (3,4), (0,2)}));
    Check.Equal(0, Solution.Solve(0, Array.Empty<(int, int)>()));
    var ds = new DisjointSet(3); ds.Union(0, 1); ds.Union(1, 0); Check.Equal(2, ds.ComponentCount); Check.Equal(ds.Find(0), ds.Find(1));
    Console.WriteLine("PASS: union-find");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement union-find in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
