using System;
using System.Collections.Generic;

public class Program6B6
{
    public static void Run()
    {
        Console.WriteLine("Program6B6 - Shopping List Manager");
        
        List<string> shoppingList = new List<string>();
        string choice;
        
        do
        {
            Console.WriteLine("\n--- Shopping List Menu ---");
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Remove item");
            Console.WriteLine("3. View list");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.Write("Enter item to add: ");
                    string newItem = Console.ReadLine();
                    if (!shoppingList.Contains(newItem))
                    {
                        shoppingList.Add(newItem);
                        Console.WriteLine($"'{newItem}' added to the list.");
                    }
                    else
                    {
                        Console.WriteLine($"'{newItem}' already exists in the list.");
                    }
                    break;
                    
                case "2":
                    Console.Write("Enter item to remove: ");
                    string itemToRemove = Console.ReadLine();
                    if (shoppingList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"'{itemToRemove}' removed from the list.");
                    }
                    else
                    {
                        Console.WriteLine($"'{itemToRemove}' not found in the list.");
                    }
                    break;
                    
                case "3":
                    Console.WriteLine("\n--- Shopping List ---");
                    if (shoppingList.Count == 0)
                    {
                        Console.WriteLine("List is empty.");
                    }
                    else
                    {
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                        }
                    }
                    break;
                    
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                    
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (choice != "4");
    }
}