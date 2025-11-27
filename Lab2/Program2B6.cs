using System;

namespace ConsoleApp1.Lab2
{
    public class Program2B6
    {
        public static void Run()
        {
        Console.WriteLine("Enter the password: ");
        string password = Console.ReadLine();
        int upper = 0 , lower=0 , special = 0 , digit = 0 , chars = 0;

        foreach (char ch in password)
        {
            if (Char.IsLetter(ch))
            {
                chars++;

                if (Char.IsUpper(ch))
                {
                    upper++;
                }
                else if (Char.IsLower(ch))
                {
                    lower++;
                }
            }
            else if (Char.IsDigit(ch))
            {
                digit++;
            }
            else  
            {
                special++;
            }
        }
        if ((password.Length < 8) || (digit < 1) || (upper < 1) || (lower < 1) || (special < 1))
                {

                    Console.WriteLine("Password is not strong " + password.Length + " " + digit + " " + upper+ " " + lower+ " " + special);
                }
        else
        {
            Console.WriteLine("Password is correct and strong");
        }
        }
    }
}