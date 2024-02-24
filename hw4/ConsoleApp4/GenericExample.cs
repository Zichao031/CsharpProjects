namespace ConsoleApp4;

public static class GenericExample<T, T2> {

    public static bool Equal(T a, T2 b)
    {
        return a.Equals(b);
    }
}