try
{
    Check.Sequence(new string[] {"1", "2", "Fizz", "4", "Buzz"}, Solution.Solve(5));
    Check.Equal("FizzBuzz", Solution.Solve(15)[14]);
    Check.Sequence(Array.Empty<string>(), Solution.Solve(0));
    Console.WriteLine("PASS: fizzbuzz");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement fizzbuzz in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
