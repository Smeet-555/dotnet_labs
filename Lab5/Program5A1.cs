using System;


class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eat");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog Barks");
    }
}

public class Program5A1
{
    public static void Run()
    {
        Dog  dog = new Dog();
        dog.Eat();
        dog.Bark();
    }
}
