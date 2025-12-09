using System;

class Shape
{
    public virtual void Area()
    {
        Console.WriteLine("Calculating area");
    }
}

class Circle : Shape
{
    public override void Area()
    {
        Console.WriteLine("Enter radius");
        int radius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The area of circle is : " + (Math.PI*radius*radius));
    }
}

class Rectangle : Shape
{
    public override void Area()
    {
        Console.WriteLine("Enter height");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter width");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The area of rectangle is : " + (width * height));
    }
}
public class Program5A3
{
    public static void Run()
    {
        Shape shape = new Circle();
        shape.Area();
        shape = new Rectangle();
        shape.Area();
    }
}
