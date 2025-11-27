// Write a C# program to check whether a given number is a prime number or
// not using a for loop and conditional statements

using System;

namespace ConsoleApp1.Lab2
{
    public class Program2B7
    {
        public static void Run()
        {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            int i = 2;

            while (i <= num / 2)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
                i++;
            }
        }

        if (isPrime)
            Console.WriteLine($"{num} is a Prime Number");
        else
            Console.WriteLine($"{num} is NOT a Prime Number");
        }
    }
}
