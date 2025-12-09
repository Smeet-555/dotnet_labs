using System;

abstract class Payment
{
    public abstract void MakePayment(int amount);
}

class CreditCardPayment : Payment
{
    public override void MakePayment(int amount)
    {
        Console.WriteLine($"Paid {amount}Rs using Credit Card.");
    }
}

class UPIPayment : Payment
{
    public override void MakePayment(int amount)
    {
        Console.WriteLine($"Paid {amount}Rs using UPI.");
    }
}

public class Program5C7
{
    public static void Run()
    {
        try
        {
            Console.WriteLine("Enter the amount to be paid:");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount < 100)
            {
                throw new Exception("Amount must be at least 100.");
            }

            Console.WriteLine("Choose Payment Method:\n1. Credit Card\n2. UPI");
            int choice = Convert.ToInt32(Console.ReadLine());

            Payment payment;

            if (choice == 1)
            {
                payment = new CreditCardPayment();
            }
            else if (choice == 2)
            {
                payment = new UPIPayment();
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting...");
                return;
            }

            payment.MakePayment(amount);
        }
        catch (Exception e)
        {
            Console.WriteLine("Payment Failed: " + e.Message);
        }
    }
}