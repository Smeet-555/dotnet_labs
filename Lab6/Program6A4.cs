using System;

 class Lab_6_A4
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        string cleaned = input.Replace(" ", "").ToLower();

        char[] arr = cleaned.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        
        if (cleaned == reversed)
        {
            Console.WriteLine("The string is a Palindrome.");
        }
        else
        {
            Console.WriteLine("The string is NOT a Palindrome.");
        }
    }
}
