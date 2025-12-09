using System;
using System.Collections.Generic;

interface IRentable
{
    double CalculateRent();
    void DisplayDetails();
}

partial class Car : IRentable
{
    public string Model;
    public int Days;
    public double RentPerDay = 1000;   

    public Car(string model, int days)
    {
        Model = model;
        Days = days;
    }

    public double CalculateRent()
    {
        return Days * RentPerDay;
    }

    public void DisplayDetails()
    {
        double rent = CalculateRent();
        Console.WriteLine($"Car Model: {Model}");
        Console.WriteLine($"Days Rented: {Days}");
        Console.WriteLine($"Total Rent: ₹{rent}");
        Console.WriteLine("-----------------------------");
    }
}

class Bike : IRentable
{
    public string Model;
    public int Days;
    public double RentPerDay = 300;  

    public Bike(string model, int days)
    {
        Model = model;
        Days = days;
    }

    public double CalculateRent()
    {
        return Days * RentPerDay;
    }

    public void DisplayDetails()
    {
        double rent = CalculateRent();
        Console.WriteLine($"Bike Model: {Model}");
        Console.WriteLine($"Days Rented: {Days}");
        Console.WriteLine($"Total Rent: ₹{rent}");
        Console.WriteLine("-----------------------------");
    }
}

class Program5C9
{
    public static void Run()
    {
        List<IRentable> rentals = new List<IRentable>();

        rentals.Add(new Car("Honda City", 3));
        rentals.Add(new Bike("Royal Enfield", 5));
        rentals.Add(new Car("Toyota Innova", 2));
        rentals.Add(new Bike("Honda Shine", 4));


        foreach (IRentable rent in rentals)
        {
            rent.DisplayDetails();
        }
    }
}