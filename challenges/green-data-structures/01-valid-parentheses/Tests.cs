try
{
    Check.Equal(true, Solution.Solve("([]{})"));
    Check.Equal(false, Solution.Solve("([)]"));
    Check.Equal(false, Solution.Solve("("));
    Check.Equal(true, Solution.Solve(""));
    Console.WriteLine("PASS: valid-parentheses");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement valid-parentheses in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
