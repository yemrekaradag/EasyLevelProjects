namespace Utils;

public static class Validator
{
    public static bool TryParseDepth(string? input, out int depth, out string? error)
    {
        error = null;
        depth = 0;

        if (string.IsNullOrWhiteSpace(input))
        {
            error = "Input cannot be empty.";
            return false;
        }

        if (!int.TryParse(input, out depth))
        {
            error = "Please enter a valid integer value.";
            return false;
        }

        if (depth < 0)
        {
            error = "Depth cannot be negative.";
            return false;
        }

        if (depth > 92)
        {
            error = "Depth is too large. Please enter a value of 92 or less.";
            return false;
        }

        return true;
    }
}