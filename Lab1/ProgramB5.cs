using System;

class ProgramB5
{
    public static void Run()
    {
        Console.WriteLine("Enter your basic salary: ");
        int salary = Convert.ToInt32(Console.ReadLine());

        double HRA = salary*0.1 ;
        Console.WriteLine("HRA : " + HRA ,2);

        double DA = salary*0.15;
        Console.WriteLine("DA : " + DA , 2);

        double deductions = salary*0.08;
        Console.WriteLine("Deductions : " + deductions , 2);

        Console.WriteLine("Gross Salary: " + salary);
        Console.WriteLine("Net Salary: " + (salary - HRA - DA - deductions));

    }
}
