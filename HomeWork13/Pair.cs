public class Pair<S, T>
{
    public S A { get; init; }
    public T B { get; init; }
    public Pair(S a, T b)
    {
        A = a;
        B = b;
    }
}
