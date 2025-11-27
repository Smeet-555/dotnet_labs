using System;
using System.Security.Cryptography;

namespace ConsoleApp1.Lab2
{
    public class Program2B4
    {
        public static void Run()
        {
        Console.WriteLine("Enter start : ");
        int start  = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter end : ");
        int end  = Convert.ToInt32(Console.ReadLine());

        int odd_sum = 0 , even_sum =0;

        for (int i = start; i <= end; i++)
        {
            if (i%2 == 0)
            {
                even_sum+=i;
            }
            else
            {
                odd_sum+=i;
            }
        }
        Console.WriteLine("Sum of even numbers: " + even_sum);
        Console.WriteLine("Sum of odd numbers: " + odd_sum);

        }
    }
}