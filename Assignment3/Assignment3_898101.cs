using System;

public class BankAccount
{
    // Properties
    public string AccountNumber { get; }
    public double Balance { get; private set; }
    public string Type { get; }
    public string OwnerName { get; } 
    public double InterestRate { get; } 

    // Constructors
    public BankAccount(string accountNumber, string ownerName, double interestRate = 0.0, double initialBalance = 0, string type = "Checking")
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = type;
        OwnerName = ownerName;
        InterestRate = interestRate;
    }

    // Methods
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount should be greater than zero.");
            return;
        }
        Balance += amount;
        Console.WriteLine($"{amount} deposited into {Type} account. New balance: {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount should be greater than zero.");
            return;
        }
        if (Balance < amount)
        {
            Console.WriteLine($"Cannot Withdraw Amount {amount}. Insufficient funds");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"{amount} withdrawn from {Type} account. New balance: {Balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Testing different constructors and methods
        BankAccount checkingAccount = new BankAccount("123456789", "Pusendra Chaudhary");
        BankAccount savingAccount = new BankAccount("987654321", "Max Gurung", 0.5, 1000, "Savings");

        // Displaying account details
        Console.WriteLine($"Checking Account Number: {checkingAccount.AccountNumber}, Owner: {checkingAccount.OwnerName}, Balance: {checkingAccount.Balance}, Type: {checkingAccount.Type}");
        Console.WriteLine($"Savings Account Number: {savingAccount.AccountNumber}, Owner: {savingAccount.OwnerName}, Balance: {savingAccount.Balance}, Type: {savingAccount.Type}, Interest Rate: {savingAccount.InterestRate}%");

        // Deposit and withdraw from checking account
        checkingAccount.Deposit(500);
        checkingAccount.Withdraw(200);
        checkingAccount.Withdraw(500); // Insufficient funds test

        // Deposit and withdraw from savings account
        savingAccount.Deposit(200);
        savingAccount.Withdraw(1500); // Insufficient funds test

        // Testing property values after transactions
        Console.WriteLine($"Checking Account Balance after transactions: {checkingAccount.Balance}");
        Console.WriteLine($"Savings Account Balance after transactions: {savingAccount.Balance}");

        Console.ReadLine();
    }
}

