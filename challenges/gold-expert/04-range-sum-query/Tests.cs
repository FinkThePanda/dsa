try
{
    var input = new[] {1, 3, 5}; var tree = Solution.Solve(input);
    Check.Equal(9L, tree.Query(0, 2)); tree.Update(1, 2); Check.Equal(8L, tree.Query(0, 2)); Check.Equal(7L, tree.Query(1, 2));
    Check.Equal(3, input[1]); Check.Equal(5L, tree.Query(2, 2));
    Console.WriteLine("PASS: range-sum-query");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement range-sum-query in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
