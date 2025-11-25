using System;

class ProgramA2
{
    public static void Run()
    {
        Console.Write("Enter number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("num 1 :" + num1);
        Console.WriteLine("num 2 :" + num2);
    }
}