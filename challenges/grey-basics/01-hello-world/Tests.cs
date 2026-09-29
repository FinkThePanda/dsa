try
{
    Check.Equal("Hello, DSA!", Solution.Solve());
    Console.WriteLine("PASS: hello-world");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement hello-world in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
