try
{
    Check.Equal("olleh", Solution.Solve("hello"));
    Check.Equal("", Solution.Solve(""));
    Check.Equal("!a b", Solution.Solve("b a!"));
    Console.WriteLine("PASS: reverse-string");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement reverse-string in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
