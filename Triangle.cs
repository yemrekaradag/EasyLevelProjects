namespace TriangleDrawerApp;

public class Triangle
{
    private readonly int _height;

    public Triangle(int height)
    {
        _height = height;
    }

    public void Draw()
    {
        for (int i = 1; i <= _height; i++)
        {
            PrintLine(i);
        }
    }

    private void PrintLine(int starsCount)
    {
        Console.Write(new string(' ', _height - starsCount));

        Console.WriteLine(new string('*', 2 * starsCount - 1));
    }
}