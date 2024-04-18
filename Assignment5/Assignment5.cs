using System;
using System.Collections.Generic;
public abstract class Mail
{
    protected double weight; // in grams
    protected bool express;
    protected string destinationAddress;

    public Mail(double weight, bool express, string destinationAddress)
    {
        this.weight = weight;
        this.express = express;
        this.destinationAddress = destinationAddress;
    }

    public abstract double Stamp();
    public abstract bool IsValid();
    public abstract void Display();
}

public class Letter : Mail
{
    private string format;

    public Letter(double weight, bool express, string destinationAddress, string format)
        : base(weight, express, destinationAddress)
    {
        this.format = format;
    }

    public override double Stamp()
    {
        if (!IsValid()) return 0;
        double baseFare = format == "A4" ? 2.50 : 3.50;
        double amount = baseFare + (weight / 1000) * 1.0;
        return express ? 2 * amount : amount;
    }

    public override bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(destinationAddress);
    }

    public override void Display()
    {
        Console.WriteLine($"Letter");
        if (!IsValid()) Console.WriteLine($"(Invalid courier)");
        Console.WriteLine($"Weight: {weight} grams");
        Console.WriteLine($"Express: {(express ? "yes" : "no")}");
        Console.WriteLine($"Destination: {destinationAddress}");
        Console.WriteLine($"Price: ${Stamp():0.0}");
        Console.WriteLine($"Format: {format}\n");
    }
}

public class Parcel : Mail
{
    private double volume;

    public Parcel(double weight, bool express, string destinationAddress, double volume)
        : base(weight, express, destinationAddress)
    {
        this.volume = volume;
    }

    public override double Stamp()
    {
        if (!IsValid()) return 0;
        double amount = 0.25 * volume + (weight / 1000) * 1.0;
        return express ? 2 * amount : amount;
    }

    public override bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(destinationAddress) && volume <= 50;
    }

    public override void Display()
    {
        Console.WriteLine($"Parcel");
        if (!IsValid()) Console.WriteLine($"(Invalid courier)");
        Console.WriteLine($"Weight: {weight} grams");
        Console.WriteLine($"Express: {(express ? "yes" : "no")}");
        Console.WriteLine($"Destination: {destinationAddress}");
        Console.WriteLine($"Price: ${Stamp():0.0}");
        Console.WriteLine($"Volume: {volume} liters\n");
    }
}

public class Advertisement : Mail
{
    public Advertisement(double weight, bool express, string destinationAddress)
        : base(weight, express, destinationAddress)
    {
    }

    public override double Stamp()
    {
        if (!IsValid()) return 0;
        double amount = 5.0 * (weight / 1000);
        return express ? 2 * amount : amount;
    }

    public override bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(destinationAddress);
    }

    public override void Display()
    {
        Console.WriteLine($"Advertisement");
        if (!IsValid()) Console.WriteLine($"(Invalid courier)");
        Console.WriteLine($"Weight: {weight} grams");
        Console.WriteLine($"Express: {(express ? "yes" : "no")}");
        Console.WriteLine($"Destination: {destinationAddress}");
        Console.WriteLine($"Price: ${Stamp():0.0}\n");
    }
}
public class Mailbox
{
    private List<Mail> mails = new List<Mail>();

    public void AddMail(Mail mail)
    {
        mails.Add(mail);
    }

    public double Stamp()
    {
        double totalPostage = 0.0;
        foreach (Mail mail in mails)
        {
            if (mail.IsValid())
            {
                totalPostage += mail.Stamp();
            }
        }
        return totalPostage;
    }

    public int InvalidMails()
    {
        int count = 0;
        foreach (Mail mail in mails)
        {
            if (!mail.IsValid())
            {
                count++;
            }
        }
        return count;
    }

    public void Display()
    {
        foreach (Mail mail in mails)
        {
            mail.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        Mailbox mailbox = new Mailbox();
        mailbox.AddMail(new Letter(200.0, true, "Chemin des Acacias 28, 1009 Pully", "A3"));
        mailbox.AddMail(new Letter(800.0, false, "", "A4"));
        mailbox.AddMail(new Advertisement(1500.0, true, "Les Moilles 13A, 1913 Saillon"));
        mailbox.AddMail(new Advertisement(3000.0, false, ""));
        mailbox.AddMail(new Parcel(5000.0, true, "Grand rue 18, 1950 Sion", 30.0));
        mailbox.AddMail(new Parcel(3000.0, true, "Chemin des fleurs 48, 2800 Delemont", 70.0));

        double totalPostage = mailbox.Stamp();
        Console.WriteLine($"The total amount of postage is {totalPostage:0.0}");

        mailbox.Display();

        int invalidCount = mailbox.InvalidMails();
        Console.WriteLine($"The box contains {invalidCount} invalid mails");
    }
}
