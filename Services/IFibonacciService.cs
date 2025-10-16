namespace Services;


public interface IFibonacciService
{
    IEnumerable<long> Generate(int count);
}