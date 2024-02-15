using System;

class Program
{
    static void Main(string[] args)
    {
        double x;
        Console.Write("Enter a real number: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Invalid input. Please enter a valid real number.");
            Console.Write("Enter a real number: ");
        }

        // Check the membership of x in the set I: [2, 3[ U [0, 1[ U [-10, -2]
        if ((x >= 2 && x < 3) || (x > 0 && x <=1) || (x >= -10 && x <= -2))
        {
            Console.WriteLine(x+" "+"x belongs to I");
        }
        else
        {
            Console.WriteLine(x+" "+"x does not belong to I");
        }
    }
}