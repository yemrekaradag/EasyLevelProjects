namespace CircleDrawerApp;

public static class ConsoleUI
{
    public static void Run()
    {
        Console.WriteLine("Welcome to the Circle Drawer!");
        int radius = ReadCircleRadius();

        Circle circle = new Circle(radius);
        circle.Draw();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    private static int ReadCircleRadius()
    {
        int radius;
        while (true)
        {
            Console.Write("Enter circle radius (positive integer): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out radius) && radius > 0)
                break;
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
        return radius;
    }
}