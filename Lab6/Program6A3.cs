using System;


class Program6A3
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowelCount = 0;
        int consonantCount = 0;

        string vowels = "aeiouAEIOU";

        foreach (char c in input)
        {
            if (char.IsLetter(c))           
            {
                if (vowels.Contains(c))     
                {
                    vowelCount++;
                }
                else                        
                {
                    consonantCount++;
                }
            }
        }

        Console.WriteLine($"Vowels: {vowelCount}");
        Console.WriteLine($"Consonants: {consonantCount}");
    }
}
