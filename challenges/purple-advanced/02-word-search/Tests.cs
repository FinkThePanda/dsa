try
{
    var board = new[] {"ABCE".ToCharArray(), "SFCS".ToCharArray(), "ADEE".ToCharArray()};
    Check.Equal(true, Solution.Solve(board, "ABCCED"));
    Check.Equal(false, Solution.Solve(board, "ABCB"));
    Check.Equal("ABCE", new string(board[0]));
    Check.Equal(true, Solution.Solve(Array.Empty<char[]>(), ""));
    Console.WriteLine("PASS: word-search");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement word-search in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
