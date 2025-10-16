namespace ReverseCharShiftApp;

public class CharacterShifter
{
    public string MoveFirstCharToEnd(string word)
    {
        if (string.IsNullOrEmpty(word) || word.Length < 2)
            return word;

        string rest = word.Substring(1);
        char firstChar = word[0];
        return rest + firstChar;
    }
}