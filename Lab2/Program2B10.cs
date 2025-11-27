using System;

namespace ConsoleApp1.Lab2
{
    public class Program2B10
    {
        public static void Run()
        {
        Console.Write("Enter the number of terms: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c;

        Console.Write("Fibonacci Series: ");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
        }
    }
}
