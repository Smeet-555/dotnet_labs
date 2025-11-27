using System;

namespace ConsoleApp1.Lab2
{
    public class Program2A1
    {
        public static void Run()
        {
        Console.WriteLine("Enter the number to print the table:  ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(num + "x" + i + " =" + (num*i) );
        }
        }
    }
}