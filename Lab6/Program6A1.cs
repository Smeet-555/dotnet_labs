using System;
using System.Collections;


public class Program6A1
{
    public static void Run()
    {
        Stack<string> stack = new Stack<string>();
        int choice;
        int i = 1;
        Console.WriteLine("Enter 1 to Add Task and 0 to UNDO Task");
        choice = Convert.ToInt16(Console.ReadLine());

        do
        {
            stack.Push($"Task {i} Added");
            i++;
            choice = Convert.ToInt16(Console.ReadLine());
        } while (choice == 1);
        
        if (choice == 0)
        {
            stack.Pop();
            Console.WriteLine("Last Task Removed");
        } 
        //The popping from the stack happens from last to first because of its LIFO nature. 
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
        

    }
}