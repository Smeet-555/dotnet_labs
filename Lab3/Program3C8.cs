using System;

class CarRental
{
    public string carModel;
    public double dailyRate;
    public int rentedDays;

    public CarRental(string model, double rate, int days)
    {
        carModel = model;
        dailyRate = rate;
        rentedDays = days;
    }

    public double CalculateRent()
    {
        if (rentedDays <= 0)
            throw new Exception("Rented days must be greater than zero.");

        return dailyRate * rentedDays;
    }
}


class Program3C8
{
    static void Run()
    {
        try
        {
            CarRental car = new CarRental("Honda City", 60, 3);
            Console.WriteLine("Total Rent: " + car.CalculateRent());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
