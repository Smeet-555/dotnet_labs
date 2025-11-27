using System;

namespace ConsoleApp1.Lab2
{
    public class Program2B9
    {
        public static void Run()
        {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int original = n;
        int rem = 0, rev = 0;

        while (n != 0)
        {
            rem = n % 10;         // get last digit
            rev = rev * 10 + rem; // build reversed number
            n /= 10;              // remove last digit
        }

        if (rev == original)
            Console.WriteLine($"{original} is a Palindrome Number");
        else
            Console.WriteLine($"{original} is NOT a Palindrome Number");
        }
    }
}
