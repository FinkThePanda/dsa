public static class Solution
{
    public static ListNode? Solve(ListNode? head)
        => throw new NotImplementedException("Your turn: implement this exercise.");
}

public sealed class ListNode(int value, ListNode? next = null)
{
    public int Value = value;
    public ListNode? Next = next;
}
