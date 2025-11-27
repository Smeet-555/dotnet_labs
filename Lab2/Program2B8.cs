using System;

namespace ConsoleApp1.Lab2
{
    public class Program2B8
    {
        public static void Run()
        {
        Console.WriteLine("Enter a number here:  ");
        int n = Convert.ToInt32(Console.ReadLine());
        int rem = 0 , rev = 0;

        while (n != 0)
        {
            rem = n%10;
            rev = rem + rev*10;
            n /= 10;
        }
        Console.WriteLine(rev);
        }
    }
}