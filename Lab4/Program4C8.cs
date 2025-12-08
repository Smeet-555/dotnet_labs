//  Design a billing system using polymorphism. Create a base class Customer
// with method CalculateBill() and derived classes RegularCustomer and
//     PremiumCustomer that override it with different discount logics.
//     Demonstrate access modifiers for secure data access.

using System;

namespace ConsoleApp1.Lab4
{
    class Customer
{
    protected string Name;
    protected double Amount;

    public Customer(string name, double amount)
    {
        Name = name;
        Amount = amount;
    }

    public virtual double CalculateBill()
    {
        return Amount; 
    }
}

class RegularCustomer : Customer
{
    public RegularCustomer(string name, double amount)
        : base(name, amount)
    {
    }

    public override double CalculateBill()
    {
        return Amount * 0.90;
    }
}

class PremiumCustomer : Customer
{
    public PremiumCustomer(string name, double amount)
        : base(name, amount)
    {
    }

    public override double CalculateBill()
    {
        return Amount * 0.75;
    }
}

    class Program4C8
    {
        public static void Run()
    {
        Customer c1 = new RegularCustomer("Smit", 1000);
        Customer c2 = new PremiumCustomer("asdfg", 1000);

        Console.WriteLine("Regular Customer Bill: " + c1.CalculateBill());
        Console.WriteLine("Premium Customer Bill: " + c2.CalculateBill());
        }
    }
}
