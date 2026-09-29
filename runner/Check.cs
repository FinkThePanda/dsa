public static class Check
{
    public static void Equal<T>(T expected, T actual)
    {
        if (!EqualityComparer<T>.Default.Equals(expected, actual))
            throw new Exception($"Expected {expected}, got {actual}.");
    }

    public static void Sequence<T>(IEnumerable<T> expected, IEnumerable<T> actual)
    {
        var e = expected.ToArray();
        var a = actual.ToArray();
        if (!e.SequenceEqual(a))
            throw new Exception($"Expected [{string.Join(", ", e)}], got [{string.Join(", ", a)}].");
    }

    public static void Throws<T>(Action action) where T : Exception
    {
        try { action(); }
        catch (T) { return; }
        throw new Exception($"Expected {typeof(T).Name}.");
    }
}
