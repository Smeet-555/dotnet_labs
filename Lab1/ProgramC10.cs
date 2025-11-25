using System;

class ProgramC10
{
    public static void Run()
    {
        Console.WriteLine("Select Vehicle Type (1-Sedan, 2-SUV, 3-Luxury): ");
        int vehicle_choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Distance (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Trip Type (1 = One-way, 2 = Round-trip): ");
        int trip_type = Convert.ToInt32(Console.ReadLine());

        double rate_per_km = 0;
        double driver_allowance = 0;

        switch (vehicle_choice)
        {
            case 1:
                rate_per_km = 12;
                driver_allowance = 500;
                break;

            case 2:
                rate_per_km = 15;
                driver_allowance = 700;
                break;

            case 3:
                rate_per_km = 20;
                driver_allowance = 1000;
                break;

            default:
                Console.WriteLine("Invalid vehicle type selected!");
                return;
        }


        double total_dist = distance;
        if (trip_type == 2)
            total_dist *= 2;   


        double baseFare = total_dist * rate_per_km;


        double discount = 0;
        if (distance > 100)
            discount = baseFare * 0.10;


        double fare_disc = baseFare - discount;

        double surcharge_fuel = fare_disc * 0.05;

        double allowance = (total_dist > 150) ? driver_allowance : 0;

        double final_amt = fare_disc + surcharge_fuel + allowance;

        // OUTPUT
        Console.WriteLine("\n----------- BILL -----------");
        Console.WriteLine("Total Distance: " + total_dist + " km");
        Console.WriteLine("Base Fare: " + baseFare);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Fuel Surcharge (5%): " + surcharge_fuel);
        Console.WriteLine("Driver Allowance: " + allowance);
        Console.WriteLine("Final Payable Fare: " + final_amt);
    }
}
