using System;
using System.Collections.Generic;

public class Program6C10
{
    public static void Run()
    {
        Console.WriteLine("Program6C10 - Hospital Queue System");
        
        Queue<string> normalPatients = new Queue<string>();
        Queue<string> emergencyPatients = new Queue<string>();
        string choice;
        
        do
        {
            Console.WriteLine("\n--- Hospital Queue Management System ---");
            Console.WriteLine("1. Add Normal patient");
            Console.WriteLine("2. Add Emergency patient");
            Console.WriteLine("3. Serve next patient");
            Console.WriteLine("4. View Normal patients queue");
            Console.WriteLine("5. View Emergency patients queue");
            Console.WriteLine("6. View all queues");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.Write("Enter normal patient name: ");
                    string normalPatient = Console.ReadLine();
                    normalPatients.Enqueue(normalPatient);
                    Console.WriteLine($"Normal patient '{normalPatient}' added to queue.");
                    Console.WriteLine($"Position in normal queue: {normalPatients.Count}");
                    break;
                    
                case "2":
                    Console.Write("Enter emergency patient name: ");
                    string emergencyPatient = Console.ReadLine();
                    emergencyPatients.Enqueue(emergencyPatient);
                    Console.WriteLine($"Emergency patient '{emergencyPatient}' added to priority queue.");
                    Console.WriteLine($"Position in emergency queue: {emergencyPatients.Count}");
                    break;
                    
                case "3":
                    // Emergency patients are always served first
                    if (emergencyPatients.Count > 0)
                    {
                        string nextEmergencyPatient = emergencyPatients.Dequeue();
                        Console.WriteLine($"Serving EMERGENCY patient: '{nextEmergencyPatient}'");
                        Console.WriteLine($"Remaining emergency patients: {emergencyPatients.Count}");
                    }
                    else if (normalPatients.Count > 0)
                    {
                        string nextNormalPatient = normalPatients.Dequeue();
                        Console.WriteLine($"Serving normal patient: '{nextNormalPatient}'");
                        Console.WriteLine($"Remaining normal patients: {normalPatients.Count}");
                    }
                    else
                    {
                        Console.WriteLine("No patients in either queue.");
                    }
                    break;
                    
                case "4":
                    Console.WriteLine("\n--- Normal Patients Queue ---");
                    if (normalPatients.Count == 0)
                    {
                        Console.WriteLine("No normal patients in queue.");
                    }
                    else
                    {
                        Console.WriteLine($"Total normal patients: {normalPatients.Count}");
                        int position = 1;
                        foreach (string patient in normalPatients)
                        {
                            Console.WriteLine($"{position}. {patient}");
                            position++;
                        }
                    }
                    break;
                    
                case "5":
                    Console.WriteLine("\n--- Emergency Patients Queue ---");
                    if (emergencyPatients.Count == 0)
                    {
                        Console.WriteLine("No emergency patients in queue.");
                    }
                    else
                    {
                        Console.WriteLine($"Total emergency patients: {emergencyPatients.Count}");
                        int position = 1;
                        foreach (string patient in emergencyPatients)
                        {
                            Console.WriteLine($"{position}. {patient} (EMERGENCY)");
                            position++;
                        }
                    }
                    break;
                    
                case "6":
                    Console.WriteLine("\n--- All Patient Queues ---");
                    Console.WriteLine($"Emergency patients ({emergencyPatients.Count}):");
                    if (emergencyPatients.Count == 0)
                    {
                        Console.WriteLine("  None");
                    }
                    else
                    {
                        int emergencyPos = 1;
                        foreach (string patient in emergencyPatients)
                        {
                            Console.WriteLine($"  {emergencyPos}. {patient} (EMERGENCY - Priority)");
                            emergencyPos++;
                        }
                    }
                    
                    Console.WriteLine($"\nNormal patients ({normalPatients.Count}):");
                    if (normalPatients.Count == 0)
                    {
                        Console.WriteLine("  None");
                    }
                    else
                    {
                        int normalPos = 1;
                        foreach (string patient in normalPatients)
                        {
                            Console.WriteLine($"  {normalPos}. {patient}");
                            normalPos++;
                        }
                    }
                    
                    Console.WriteLine($"\nNext to be served: ");
                    if (emergencyPatients.Count > 0)
                    {
                        Console.WriteLine($"  EMERGENCY: {emergencyPatients.Peek()}");
                    }
                    else if (normalPatients.Count > 0)
                    {
                        Console.WriteLine($"  Normal: {normalPatients.Peek()}");
                    }
                    else
                    {
                        Console.WriteLine("  No patients waiting");
                    }
                    break;
                    
                case "7":
                    Console.WriteLine("Hospital system shutting down. Goodbye!");
                    break;
                    
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (choice != "7");
    }
}