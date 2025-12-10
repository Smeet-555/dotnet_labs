using System;
using System.Collections.Generic;

public class Program6B7
{
    public static void Run()
    {
        Console.WriteLine("Program6B7 - Word Occurrence Counter using Dictionary");
        
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        string[] words = sentence.ToLower()
                                .Replace(",", "")
                                .Replace(".", "")
                                .Replace("!", "")
                                .Replace("?", "")
                                .Replace(";", "")
                                .Replace(":", "")
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        Dictionary<string, int> wordOccurrences = new Dictionary<string, int>();
        
        
        foreach (string word in words)
        {
            if (wordOccurrences.ContainsKey(word))
            {
                wordOccurrences[word]++;
            }
            else
            {
                wordOccurrences[word] = 1;
            }
        }
        
        Console.WriteLine("\nWord occurrences in the sentence:");
        foreach (KeyValuePair<string, int> pair in wordOccurrences)
        {
            Console.WriteLine($"'{pair.Key}' appears {pair.Value} time(s)");
        }
        
        Console.WriteLine($"\nTotal unique words: {wordOccurrences.Count}");
        Console.WriteLine($"Total words: {words.Length}");
    }
}