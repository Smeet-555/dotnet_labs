using System;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

public class Program4A1
{
    public static void Run()
    {
        Calculator calc = new Calculator();

        int result1 = calc.Add(5, 10); 
        Console.WriteLine($"Sum of two integers: {result1}");

        int result2 = calc.Add(5, 10, 15); 
        Console.WriteLine($"Sum of three integers: {result2}");

        double result3 = calc.Add(5.5, 10.2); 
        Console.WriteLine($"Sum of two doubles: {result3}");
    }
}