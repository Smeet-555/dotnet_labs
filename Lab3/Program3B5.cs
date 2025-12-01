using System;

namespace ConsoleApp1.Lab3
{

    public class Student()
    {
        string Name;
        int RollNo;
        int Marks;


        public Student (string Name, int RollNo, int Marks) :this()
        {
            Console.WriteLine("The name of Student is " + Name);
            Console.WriteLine("The RollNo of Student is " + RollNo);
            Console.WriteLine("The Marks of Student is " + Marks);
        }
        public Student(string Name, int RollNo) :this()
        {
            Console.WriteLine("The name of Student is " + Name);
            Console.WriteLine("The RollNo of Student is " + RollNo);
        }
    }
    public class Program3B5
    {

        public static void Run()
        {
            Student student1 = new Student("Smit", 1, 100);
            Console.WriteLine("--------------------------------------");
            Student student2 = new Student("Sam", 2); // this will call
            //the second created constructor as it has only 2 parameters
            
        }
    }
}