using System;
using System.Collections.Generic;

public class Program6C9
{
    public static void Run()
    {
        Console.WriteLine("Program6C9 - Library Book Borrowing System");
        
        // Dictionary where key is book title, value is queue of borrower names
        Dictionary<string, Queue<string>> libraryBooks = new Dictionary<string, Queue<string>>();
        string choice;
        
        do
        {
            Console.WriteLine("\n--- Library Book Borrowing System ---");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Add borrower to book queue");
            Console.WriteLine("3. Process next borrower (checkout)");
            Console.WriteLine("4. View borrowers for a book");
            Console.WriteLine("5. View all books and their queues");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.Write("Enter book title: ");
                    string bookTitle = Console.ReadLine();
                    if (!libraryBooks.ContainsKey(bookTitle))
                    {
                        libraryBooks[bookTitle] = new Queue<string>();
                        Console.WriteLine($"Book '{bookTitle}' added to the library.");
                    }
                    else
                    {
                        Console.WriteLine($"Book '{bookTitle}' already exists in the library.");
                    }
                    break;
                    
                case "2":
                    Console.Write("Enter book title: ");
                    string bookForBorrowing = Console.ReadLine();
                    if (libraryBooks.ContainsKey(bookForBorrowing))
                    {
                        Console.Write("Enter borrower name: ");
                        string borrowerName = Console.ReadLine();
                        libraryBooks[bookForBorrowing].Enqueue(borrowerName);
                        Console.WriteLine($"'{borrowerName}' added to the borrowing queue for '{bookForBorrowing}'.");
                        Console.WriteLine($"Position in queue: {libraryBooks[bookForBorrowing].Count}");
                    }
                    else
                    {
                        Console.WriteLine($"Book '{bookForBorrowing}' not found in the library.");
                    }
                    break;
                    
                case "3":
                    Console.Write("Enter book title: ");
                    string bookForCheckout = Console.ReadLine();
                    if (libraryBooks.ContainsKey(bookForCheckout))
                    {
                        if (libraryBooks[bookForCheckout].Count > 0)
                        {
                            string nextBorrower = libraryBooks[bookForCheckout].Dequeue();
                            Console.WriteLine($"'{nextBorrower}' has checked out '{bookForCheckout}'.");
                            Console.WriteLine($"Remaining borrowers in queue: {libraryBooks[bookForCheckout].Count}");
                        }
                        else
                        {
                            Console.WriteLine($"No borrowers in queue for '{bookForCheckout}'.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Book '{bookForCheckout}' not found in the library.");
                    }
                    break;
                    
                case "4":
                    Console.Write("Enter book title: ");
                    string bookToView = Console.ReadLine();
                    if (libraryBooks.ContainsKey(bookToView))
                    {
                        Console.WriteLine($"\nBorrowing queue for '{bookToView}':");
                        if (libraryBooks[bookToView].Count == 0)
                        {
                            Console.WriteLine("No borrowers in queue.");
                        }
                        else
                        {
                            int position = 1;
                            foreach (string borrower in libraryBooks[bookToView])
                            {
                                Console.WriteLine($"{position}. {borrower}");
                                position++;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Book '{bookToView}' not found in the library.");
                    }
                    break;
                    
                case "5":
                    Console.WriteLine("\n--- All Books and Their Borrowing Queues ---");
                    if (libraryBooks.Count == 0)
                    {
                        Console.WriteLine("No books in the library.");
                    }
                    else
                    {
                        foreach (var book in libraryBooks)
                        {
                            Console.WriteLine($"\nBook: '{book.Key}'");
                            if (book.Value.Count == 0)
                            {
                                Console.WriteLine("  No borrowers in queue.");
                            }
                            else
                            {
                                Console.WriteLine($"  Borrowers in queue ({book.Value.Count}):");
                                int position = 1;
                                foreach (string borrower in book.Value)
                                {
                                    Console.WriteLine($"    {position}. {borrower}");
                                    position++;
                                }
                            }
                        }
                    }
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
}