try
{
    var first = new ListNode(1, new ListNode(2, new ListNode(3)));
    var result = Solution.Solve(first);
    Check.Equal(3, result!.Value); Check.Equal(2, result.Next!.Value);
    Check.Equal(true, ReferenceEquals(first, result.Next.Next));
    Check.Equal<ListNode?>(null, first.Next);
    Check.Equal<ListNode?>(null, Solution.Solve(null));
    Console.WriteLine("PASS: reverse-linked-list");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement reverse-linked-list in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
