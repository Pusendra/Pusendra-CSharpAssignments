// Author: Pusendra, Student Id: 898101
using System;

class AllQuestionInOneFile
{
    static void Main()
    {
        //question 1
        Console.Write("Provide your age: ");
        int age = int.Parse(Console.ReadLine());

        int currentYear = DateTime.Now.Year;
        int birthYear = currentYear - age;

        Console.WriteLine($"Your year of birth is {birthYear}");

        //end question 1

        //question 2

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

        //end question 2


         //question 3
        Console.Write("Enter x: ");
        int x1 = int.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before swapping: x: {x1}; y: {y};");

        int temp = x1;
        x1 = y;
        y = temp;

        Console.WriteLine($"After swapping: x: {x1}; y: {y}");

        //end question 3

        //question 4

        Console.Write("How much did you receive money ($)? ");
        int totalMoney = int.Parse(Console.ReadLine());

        int booksAndSupplies = (int)(0.75 * totalMoney);

        int remainingMoney = totalMoney - booksAndSupplies;

        int coffeeCost = 2;
        int flashComputerCost = 4;
        int subwayTicketCost = 3;
        
        int remainingMoneyDividedToThreeParts = remainingMoney/3;

        int coffees = remainingMoneyDividedToThreeParts / coffeeCost;
        int flashComputers = remainingMoneyDividedToThreeParts / flashComputerCost;
        int subwayTickets = remainingMoneyDividedToThreeParts / subwayTicketCost;

        int whiteRoses = remainingMoney-(coffees*coffeeCost + flashComputers*flashComputerCost+subwayTicketCost*subwayTickets);

        Console.WriteLine($"Book and Supplies: {booksAndSupplies} $");
        Console.WriteLine("You can then buy:");
        Console.WriteLine($"{coffees} coffees");
        Console.WriteLine($"{flashComputers} Flash Computer Numbers");
        Console.WriteLine($"{subwayTickets} subway Tickets");
        Console.WriteLine($"and you will have {whiteRoses} dollars for the white roses.");


        //end question 4
    }
}