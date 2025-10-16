namespace TriangleDrawerApp;

public static class ConsoleUI
{
    public static void Run()
    {
        Console.WriteLine("Welcome to the Triangle Drawer!");
        int height = ReadTriangleHeight();

        Triangle triangle = new Triangle(height);
        triangle.Draw();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    private static int ReadTriangleHeight()
    {
        int height;
        while (true)
        {
            Console.Write("Enter triangle height (positive integer): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out height) && height > 0)
                break;
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
        return height;
    }
}