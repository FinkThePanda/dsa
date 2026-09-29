try
{
    Check.Equal(3, Solution.Solve("horse", "ros"));
    Check.Equal(5, Solution.Solve("intention", "execution"));
    Check.Equal(3, Solution.Solve("", "abc"));
    Check.Equal(0, Solution.Solve("same", "same"));
    Console.WriteLine("PASS: edit-distance");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement edit-distance in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
