namespace ReverseCharShiftApp;

public static class ConsoleUI
{
    public static void Run()
    {
        Console.WriteLine("Welcome to the Character Shift App!");
        Console.WriteLine("Enter words separated by space, e.g., 'Merhaba Hello Question'");

        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No input provided.");
            return;
        }

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        CharacterShifter shifter = new CharacterShifter();

        foreach (var word in words)
        {
            Console.Write(shifter.MoveFirstCharToEnd(word) + " ");
        }

        Console.WriteLine();
    }
}