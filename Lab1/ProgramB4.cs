using System;

class ProgramB4
{
    public static void Run()
    {
        Console.WriteLine("Enter choice (0 for Celcius to Fahareinheit) AND (1 for Fahreinheit to Celcius)");

        int choice = Convert.ToInt32(Console.ReadLine()) ;

        if (choice == 0)
        {
            Console.WriteLine("Enter the temperature in Celcius");
            int Celcius = Convert.ToInt32(Console.ReadLine());

            double fah = (Celcius * 1.8) + 32;
            Console.WriteLine("Temperature in Fahreinheit is :" + fah );
        }
        else
        {
            Console.WriteLine("Enter the temperature in Fahreinheit");
            int Fahreinheit = Convert.ToInt32(Console.ReadLine());

            double cel = (Fahreinheit - 32)/1.8;
            Console.WriteLine("Temperature in Fahreinheit is :" + cel );
        }
    }
}