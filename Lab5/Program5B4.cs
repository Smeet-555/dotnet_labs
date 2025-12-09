using System;

abstract class Appliance
{
    public abstract void TurnOn();
}

class Fan : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Fan is now spinning...");
    }
}


class Light : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Light is now glowing...");
    }
}

public class Program5B4
{
    public static void Run()
    {
        Fan fan = new Fan();
        fan.TurnOn();
        Light light = new Light();
        light.TurnOn();
    }
}
