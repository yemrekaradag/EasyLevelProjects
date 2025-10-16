using Services;
using Utils;

namespace UI;

public sealed class ConsoleUI
{
    private readonly IFibonacciService _fibonacciService;
    private readonly IAverageCalculator _averageCalculator;

    public ConsoleUI()
    {
        _fibonacciService = new FibonacciService();
        _averageCalculator = new AverageCalculator();
    }

    public void Run()
    {
        Console.WriteLine("Fibonacci Average Calculator");
        Console.WriteLine("Calculates the average of the first N Fibonacci numbers based on the user-provided depth.");

        while (true)
        {
            Console.Write("Depth (type 'q' to quit): ");
            var input = Console.ReadLine();
            if (string.Equals(input, "q", StringComparison.OrdinalIgnoreCase)) break;

            if (!Validator.TryParseDepth(input, out var depth, out var error))
            {
                Console.WriteLine($"Error: {error}");
                continue;
            }

            try
            {
                var sequence = _fibonacciService.Generate(depth);
                var average = _averageCalculator.CalculateAverage(sequence);

                Console.WriteLine($"The average of the first {depth} Fibonacci numbers is: {average:F2}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The Fibonacci numbers overflowed for the given depth. Try a smaller value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        Console.WriteLine("Program terminated. Goodbye!");
    }
}