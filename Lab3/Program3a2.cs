using System;

namespace ConsoleApp1.Lab3
{
    internal class Program3A2
    {
        public class Rectangle
        {
                double length , breadth;

                 public Rectangle(double length, double breadth)
                 {
                    this.length = length;
                    this.breadth = breadth;
                }
            

            public void area()
            {
                double area = this.length * this.breadth;
                Console.WriteLine("The area of the rectangle is: " + area);
            }
        }
        
        public static void Run()
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the rectangle: ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, breadth);
            rectangle.area();
            
        }
    }
}