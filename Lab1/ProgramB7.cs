using System;

class ProgramB7
{
    public static void Run()
    {
        Console.WriteLine("Enter the marks in subject 1: ");
        double marks1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the marks in subject 2: ");
        double marks2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the marks in subject 3: ");
        double marks3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the marks in subject 4: ");
        double marks4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the marks in subject 5: ");
        double marks5 = Convert.ToInt32(Console.ReadLine());

        double total = marks1+marks2+marks3+marks4+marks5;
        Console.WriteLine("Total marks obtained: "+ total);


        double percentage = total/5;
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
        else
        {
            Console.WriteLine("FAIL");     
        }

    }
}