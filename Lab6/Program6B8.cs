using System;
using System.Collections.Generic;

public class Program6B8
{
    public static void Run()
    {
        Console.WriteLine("Program6B8 - Email Subscriber Management using HashSet");
        
        HashSet<string> emailAddresses = new HashSet<string>();
        string choice;
        
        do
        {
            Console.WriteLine("\n--- Email Subscriber Management ---");
            Console.WriteLine("1. Add email address");
            Console.WriteLine("2. Remove email address");
            Console.WriteLine("3. Check if email exists");
            Console.WriteLine("4. Display all emails");
            Console.WriteLine("5. Display total count");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.Write("Enter email address: ");
                    string email = Console.ReadLine();
                    if (IsValidEmail(email))
                    {
                        if (emailAddresses.Add(email))
                        {
                            Console.WriteLine($"Email '{email}' added successfully.");
                        }
                        else
                        {
                            Console.WriteLine($"Email '{email}' already exists. Duplicates not allowed.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid email format. Please try again.");
                    }
                    break;
                    
                case "2":
                    Console.Write("Enter email address to remove: ");
                    string emailToRemove = Console.ReadLine();
                    if (emailAddresses.Remove(emailToRemove))
                    {
                        Console.WriteLine($"Email '{emailToRemove}' removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Email '{emailToRemove}' not found.");
                    }
                    break;
                    
                case "3":
                    Console.Write("Enter email address to check: ");
                    string emailToCheck = Console.ReadLine();
                    if (emailAddresses.Contains(emailToCheck))
                    {
                        Console.WriteLine($"Email '{emailToCheck}' exists in the system.");
                    }
                    else
                    {
                        Console.WriteLine($"Email '{emailToCheck}' does not exist in the system.");
                    }
                    break;
                    
                case "4":
                    Console.WriteLine("\n--- All Email Addresses ---");
                    if (emailAddresses.Count == 0)
                    {
                        Console.WriteLine("No email addresses stored.");
                    }
                    else
                    {
                        int count = 1;
                        foreach (string email in emailAddresses)
                        {
                            Console.WriteLine($"{count}. {email}");
                            count++;
                        }
                    }
                    break;
                    
                case "5":
                    Console.WriteLine($"Total unique email addresses: {emailAddresses.Count}");
                    break;
                    
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                    
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (choice != "6");
    }
    
    private static bool IsValidEmail(string email)
    {
        return !string.IsNullOrWhiteSpace(email) && 
               email.Contains("@") && 
               email.Contains(".") && 
               email.IndexOf("@") < email.LastIndexOf(".");
    }
}