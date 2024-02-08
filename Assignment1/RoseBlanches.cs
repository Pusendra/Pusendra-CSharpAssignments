using System;

class RoseBlanches
{
    static void Main()
    {
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
    }
}
