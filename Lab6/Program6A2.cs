using System;
using System.Collections.Generic;

public class Program6A2
{
    public static void Run()
    {
        Queue<int> queue = new Queue<int>();
        int choice;
        int customerNumber = 1;

        do
        {
            Console.WriteLine("\n1. Add Customer");
            Console.WriteLine("2. Serve Customer");
            Console.WriteLine("3. View Next Customer");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    queue.Enqueue(customerNumber);
                    Console.WriteLine($"Customer {customerNumber} Added");
                    customerNumber++;
                    break;

                case 2:
                    if (queue.Count > 0)
                    {
                        int served = queue.Dequeue();
                        Console.WriteLine($"Customer {served} Served");
                    }
                    else
                    {
                        Console.WriteLine("No customers to serve.");
                    }
                    break;

                case 3:
                    if (queue.Count > 0)
                    {
                        Console.WriteLine($"Next customer is: {queue.Peek()}");
                    }
                    else
                    {
                        Console.WriteLine("No customers in queue.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 0);
    }
}