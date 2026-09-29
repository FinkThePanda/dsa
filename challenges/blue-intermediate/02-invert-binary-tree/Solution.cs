public static class Solution
{
    public static TreeNode? Solve(TreeNode? root)
        => throw new NotImplementedException("Your turn: implement this exercise.");
}

public sealed class TreeNode(int value, TreeNode? left = null, TreeNode? right = null)
{
    public int Value = value;
    public TreeNode? Left = left;
    public TreeNode? Right = right;
}
