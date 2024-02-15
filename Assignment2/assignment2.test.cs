using System;

class Program
{
    static void Main(string[] args)
    {
        double[] values = { -20, -10, -2, -1, 0, 1, 1.5, 2, 3 , 4 };

        foreach (double x in values)
        {
            CheckMembership(x);
        }
    }

    static void CheckMembership(double x)
    {
        // Check the membership of x in the set I: [2, 3[ U [0, 1[ U [-10, -2]
        if ((x >= 2 && x < 3) || (x > 0 && x <= 1) || (x >= -10 && x <= -2))
        {
            Console.WriteLine(x + " " + "x belongs to I");
        }
        else
        {
            Console.WriteLine(x + " " + "x does not belong to I");
        }
    }
}