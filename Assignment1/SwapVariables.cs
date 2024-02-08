// Author: Pusendra, Student Id: 898101
using System;

class SwapVariables
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before swapping: x: {x}; y: {y};");

        int temp = x;
        x = y;
        y = temp;

        Console.WriteLine($"After swapping: x: {x}; y: {y}");
    }
}