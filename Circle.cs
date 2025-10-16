namespace CircleDrawerApp;

public class Circle
{
    private readonly int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }

    public void Draw()
    {
        for (int y = -_radius; y <= _radius; y++)
        {
            for (int x = -_radius; x <= _radius; x++)
            {
                if (IsInsideCircle(x, y))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    private bool IsInsideCircle(int x, int y)
    {
        double distance = Math.Sqrt(x * x + y * y);
        return distance <= _radius + 0.5 && distance >= _radius - 0.5;
    }
}