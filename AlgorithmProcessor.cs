namespace BasicAlgorithmApp;

public class AlgorithmProcessor
{
    public string RemoveCharacter(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return input;

        string[] parts = input.Split(',');
        if (parts.Length != 2)
            return input;

        string text = parts[0];
        if (!int.TryParse(parts[1], out int index))
            return input;

        if (index < 0 || index >= text.Length)
            return text;

        return text.Remove(index, 1);
    }
}