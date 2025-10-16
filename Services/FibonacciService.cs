namespace Services;

public sealed class FibonacciService : IFibonacciService
{
    public IEnumerable<long> Generate(int count)
    {
        if (count <= 0) yield break;

        long a = 0;
        long b = 1;

        for (int i = 1; i <= count; i++)
        {
            yield return a;
            checked
            {
                var next = a + b;
                a = b;
                b = next;
            }
        }
    }
}