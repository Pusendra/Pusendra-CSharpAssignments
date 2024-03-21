//Pusendra Chaudhary 898101
using System;

class Program
{
    static void Main(string[] args)
    {
        int x;
        Console.Write("Enter a real number: "); // Prompt the user to enter a real number
        while (!int.TryParse(Console.ReadLine(), out x) || x <= 0 || x > 10) // Repeat until valid input is received
        {
            Console.WriteLine("Invalid input. Please enter a positive number less than 10"); // Display error message for invalid input
            Console.Write("Enter a real number(x): "); // Prompt the user again for input
        }
        
        Console.WriteLine("Times table of {0}:", x);
        for (int i = 1; i <= 10; i++)
        {
            int multiple = i * x;
            Console.WriteLine("{0} * {1} = {2}", i, x, multiple);
        }
    }
}