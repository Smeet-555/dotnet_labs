using System;

class BankAccount
{
    private int accountNumber;
    private string holderName;
    private double balance;

    public BankAccount(int accountNumber, string holderName, double balance)
    {
        if (balance < 0)
            throw new Exception("Initial balance cannot be negative.");

        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new Exception("Deposit amount must be greater than zero.");

        balance += amount;
        Console.WriteLine("Deposit successful!");
        Display();
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new Exception("Withdrawal amount must be greater than zero.");

        if (amount > balance)
            throw new Exception("Insufficient balance! Withdrawal denied.");

        balance -= amount;
        Console.WriteLine("Withdrawal successful!");
        Display();
    }

    public void Display()
    {
        Console.WriteLine("\n--- Account Details ---");
        Console.WriteLine("Account Number : " + accountNumber);
        Console.WriteLine("Holder Name    : " + holderName);
        Console.WriteLine("Balance        : " + balance);
    }
}

class Program3B4
{
    public static void Run()
    {
        try
        {
            BankAccount account = new BankAccount(101, "John Doe", 1000);

            account.Deposit(500);     
            account.Withdraw(300);    
            account.Withdraw(1500);   // this will throw error
        }
        catch (Exception e)
        {
            Console.WriteLine("Transaction Error: " + e.Message);
        }
    }
}