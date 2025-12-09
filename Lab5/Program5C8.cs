using System;

abstract class Employee
{
    public string Name;
    public double Salary; 

    public abstract void CalculateBonus();
}

class Manager : Employee
{
    public override void CalculateBonus()
    {
        double bonus = Salary * 0.20;
        Console.WriteLine($"Manager Bonus: {bonus}");
    }
}

class Developer : Employee
{
    public override void CalculateBonus()
    {
        double bonus = Salary * 0.10;
        Console.WriteLine($"Developer Bonus: {bonus}");
    }
}

public class Program5C8
{
    public static void Run()
    {
        Console.WriteLine("Enter 1 for Manager OR 2 for Developer:");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your salary:");
        double inputSalary = double.Parse(Console.ReadLine());

        Employee emp;

        if (choice == 1)
        {
            emp = new Manager();  
        }
        else if (choice == 2)
        {
            emp = new Developer();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        emp.Salary = inputSalary;
        emp.CalculateBonus();
    }
}