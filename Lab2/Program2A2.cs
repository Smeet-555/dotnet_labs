using System;

namespace ConsoleApp1.Lab2
{
    public class Program2A2
    {
        public static void Run()
        {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        int alphabets = 0, digits = 0, special = 0 ,wh_Space = 0;

        foreach (char ch in str)
        {
            if (Char.IsLetter(ch))
            {
                alphabets++;
            }
            else if (Char.IsDigit(ch))
            {
                digits++;
            }
            else if (Char.IsWhiteSpace(ch))
            {
                wh_Space++;
            }
            else
            {
                special++;
            }
        }

        Console.WriteLine("Alphabets: " +  alphabets);
        Console.WriteLine("Digits: " +  digits);
        Console.WriteLine("Special chars: " +  special);
        Console.WriteLine("White Space: " +  wh_Space);

        }
    }
}
