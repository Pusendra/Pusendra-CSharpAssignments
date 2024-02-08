// Author: Pusendra, Student Id: 898101
using System;

class Birth
{
    static void Main()
    {
        Console.Write("Provide your age: ");
        int age = int.Parse(Console.ReadLine());

        int currentYear = DateTime.Now.Year;
        int birthYear = currentYear - age;

        Console.WriteLine($"Your year of birth is {birthYear}");
    }
}