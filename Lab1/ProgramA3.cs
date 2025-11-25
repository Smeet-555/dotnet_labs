using System;

class ProgramA3
{
public static void Run()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the name of your country: ");
        string country = Console.ReadLine();

        Console.WriteLine("Hello " + name + " from " + country);

    }
}