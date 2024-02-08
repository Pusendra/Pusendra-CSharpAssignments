// Author: Pusendra, Student Id: 898101
using System;

class Degree3
{
    static void Main()
    {
        Console.Write("Enter a (int): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b (int): ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter c (int): ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Enter x (double): ");
        double x = double.Parse(Console.ReadLine());

        double result = ((a + b) / 2.0) * Math.Pow(x, 3) + Math.Pow((a + b), 2) * Math.Pow(x, 2) + a + b + c;

        Console.WriteLine($"The value of polynomial is {result}");
    }
}