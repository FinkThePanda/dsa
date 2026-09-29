try
{
    Check.Sequence(new[] {3, 1, 4}, Solution.Solve(new[] {3, 1, 4}));
    var q = new IntQueue(); for (int i = 0; i < 100; i++) q.Enqueue(i);
    for (int i = 0; i < 50; i++) Check.Equal(i, q.Dequeue());
    for (int i = 100; i < 180; i++) q.Enqueue(i);
    for (int i = 50; i < 180; i++) Check.Equal(i, q.Dequeue());
    Check.Equal(0, q.Count); Check.Throws<InvalidOperationException>(() => q.Dequeue());
    Console.WriteLine("PASS: array-queue");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement array-queue in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
