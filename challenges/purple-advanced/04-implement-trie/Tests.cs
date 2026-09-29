try
{
    var trie = Solution.Solve(); trie.Insert("apple");
    Check.Equal(true, trie.Search("apple")); Check.Equal(false, trie.Search("app"));
    Check.Equal(true, trie.StartsWith("app")); trie.Insert("app"); Check.Equal(true, trie.Search("app"));
    Check.Equal(true, trie.StartsWith("")); trie.Insert(""); Check.Equal(true, trie.Search(""));
    Console.WriteLine("PASS: implement-trie");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement implement-trie in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
