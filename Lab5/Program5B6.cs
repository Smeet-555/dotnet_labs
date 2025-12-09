using System;

interface IMovabale
{
    public void Move();
}

interface ISound
{
    public void MakeSound();
}

class Robot :  ISound , IMovabale
{
    public void Move()
    {
        Console.WriteLine("Robot is moving");
    }
    public void MakeSound()
    {
        Console.WriteLine("Robot is playing");
    }
}

public class Program5B6
{
    public static void Run()
    {
        Robot robot = new Robot();
        robot.Move();
        robot.MakeSound();
    }
}

