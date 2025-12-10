using System;
using System.Collections.Generic;

public class Program6B5
{
    public static void Run()
    {
        Console.WriteLine("Program6B5 - Count word occurrences in a sentence");
        
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        // Split sentence into words and convert to lowercase for case-insensitive counting
        string[] words = sentence.ToLower().Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, 
                                                 StringSplitOptions.RemoveEmptyEntries);
        
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        
        // Count occurrences of each word
        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }
        
        Console.WriteLine("\nWord occurrences:");
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}