namespace BasicAlgorithmApp;

public static class ConsoleUI
{
    public static void Run()
    {
        Console.WriteLine("Welcome to the Basic Algorithm App!");
        Console.WriteLine("Enter inputs separated by space, e.g., 'Algoritma,3 Algoritma,5'");

        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No input provided.");
            return;
        }

        string[] entries = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        AlgorithmProcessor processor = new AlgorithmProcessor();

        foreach (var entry in entries)
        {
            string result = processor.RemoveCharacter(entry);
            Console.Write(result + " ");
        }

        Console.WriteLine();
    }
}