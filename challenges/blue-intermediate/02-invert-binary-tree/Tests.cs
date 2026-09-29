try
{
    var root = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3));
    Check.Equal(true, ReferenceEquals(root, Solution.Solve(root)));
    Check.Equal(3, root.Left!.Value); Check.Equal(2, root.Right!.Value); Check.Equal(4, root.Right.Right!.Value);
    Check.Equal<TreeNode?>(null, Solution.Solve(null));
    Console.WriteLine("PASS: invert-binary-tree");
}
catch (NotImplementedException)
{
    Console.Error.WriteLine("TODO: implement invert-binary-tree in Solution.cs.");
    Environment.ExitCode = 2;
}
catch (Exception error)
{
    Console.Error.WriteLine($"FAIL: {error.Message}");
    Environment.ExitCode = 1;
}
