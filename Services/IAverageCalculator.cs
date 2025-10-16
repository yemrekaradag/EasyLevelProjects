namespace Services;

public interface IAverageCalculator
{
    double CalculateAverage(IEnumerable<long> numbers);
}