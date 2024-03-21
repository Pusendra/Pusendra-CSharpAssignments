using System;

class Circle
{
    public double Radius { get; }
    private const double Pi = Math.PI;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than zero.");
        }
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Pi * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Pi * Radius;
    }

    public bool IsPointInside(double x, double y)
    {
        // Check if the distance from the center of the circle to the point is less than or equal to the radius
        return Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(Radius, 2);
    }
}

class Program
{
    static Circle[] CreateCircles(int numberOfCircles)
    {
        Circle[] circles = new Circle[numberOfCircles];
        for (int i = 0; i < numberOfCircles; i++)
        {
            double radius;
            do
            {
                Console.Write($"Enter the radius for circle {i + 1}: ");
            } while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0);

            circles[i] = new Circle(radius);
        }
        return circles;
    }

    static void PrintCircleInfo(Circle circle)
    {
        Console.WriteLine($"Circle with radius {circle.Radius}:");
        Console.WriteLine($"Area: {circle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
    }

    static (double, double) GetPoint()
    {
        double x, y;
        do
        {
            Console.Write("Enter the x-coordinate of the point: ");
        } while (!double.TryParse(Console.ReadLine(), out x));
        do
        {
            Console.Write("Enter the y-coordinate of the point: ");
        } while (!double.TryParse(Console.ReadLine(), out y));

        return (x, y);
    }

    static void Main(string[] args)
    {
        int numberOfCircles;
        do
        {
            Console.Write("Enter the number of circles to create: ");
        } while (!int.TryParse(Console.ReadLine(), out numberOfCircles) || numberOfCircles <= 0);

        Circle[] circles = CreateCircles(numberOfCircles);

        Console.WriteLine("\nCircle Information:");
        foreach (var circle in circles)
        {
            PrintCircleInfo(circle);
        }

        var point = GetPoint();

        foreach (var circle in circles)
        {
            bool isInside = circle.IsPointInside(point.Item1, point.Item2);
            Console.WriteLine($"Point ({point.Item1}, {point.Item2}) {(isInside ? "is" : "is not")} inside the circle with radius {circle.Radius}");
        }
    }
}
