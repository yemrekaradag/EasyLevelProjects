namespace Services;

public sealed class AverageCalculator : IAverageCalculator
{
    public double CalculateAverage(IEnumerable<long> numbers)
    {
        if (numbers == null) throw new ArgumentNullException(nameof(numbers));

        var arr = numbers as long[] ?? numbers.ToArray();
        if (arr.Length == 0) return 0.0;

        double sum = 0;
        foreach (var v in arr)
        {
            sum += v;
        }

        return sum / arr.Length;
    }
}