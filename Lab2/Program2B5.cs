using System;

namespace ConsoleApp1.Lab2
{
    public class Program2B5
    {
        public static void Run()
        {
        Console.WriteLine("Enter the number to find factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int factorial =1 ;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Factorial : " + factorial);
        }
    }
}