using System;

namespace ConsoleApp1.Lab3
{
    public class Program3A1
    {
        public class Student()
        {
            public string Name;
            public int RollNo;
            public int Mark;


            public void SetData(string Name , int RollNo , int Mark)
            {
                this.Name = Name;
                this.RollNo = RollNo;
                this.Mark  = Mark;
            }
            public void GetData()
            {
                Console.WriteLine("Name: " + this.Name);
                Console.WriteLine("RollNo: " + this.RollNo);
                Console.WriteLine("Marks: " + this.Mark);   
            }
        }
        
        public static void Run()
        {
            Student student1 = new Student();
            // student1.Name = "John";
            // student1.RollNo = 1;
            // student1.Mark = 80;
            student1.SetData("John Doe" , 1 , 80);
            student1.GetData();
            
            Student student2 = new Student(); 
            student2.Name = "John";
            student2.RollNo = 1;
            student2.Mark = 90;
            
            student2.GetData();
        }
    }
}