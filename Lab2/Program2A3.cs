using System;

namespace ConsoleApp1.Lab2
{
    public class Program2A3
    {
        public static void Run()
        {


        Console.WriteLine("Total marks obtained: ");
        double total = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Total subjects: ");
        int subjects = Convert.ToInt32(Console.ReadLine());


        double percentage = total/subjects;
        Console.WriteLine("Percentage obtained: "+ percentage);

        if (percentage >= 75)
        {
            Console.WriteLine("Grade: " + "A");
        }
        else if(percentage >=60)
        {
            Console.WriteLine("Grade: " + "B"); 
        }
        else if(percentage >=45)
        {
            Console.WriteLine("Grade: " + "C"); 
        }
        else if(percentage >= 35)
        {
            Console.WriteLine("Grade: " + "D");
        }
        else
        {
            Console.WriteLine("FAIL");     
        }

        }
    }
}