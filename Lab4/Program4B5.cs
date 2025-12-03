//Design a base class Shape with a virtual method CalculateArea(). Derive
//Circle, Rectangle, and Triangle classes that override this method to compute
//area based on their own formulas.


public class Shape
{
    public virtual double CalculateArea()
    {
        return 0; 
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius; 
    }
}

public class Rectangle : Shape
{
    private double length, width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double CalculateArea()
    {
        return length * width; 
    }
}

public class Triangle : Shape
{
    private double baseLength, height;

    public Triangle(double b, double h)
    {
        baseLength = b;
        height = h;
    }

    public override double CalculateArea()
    {
        return 0.5 * baseLength * height; 
    }
}

public class Program4B5
{
    public static void Run()
    {
        Shape shape = new Shape();
        shape.CalculateArea();
        Circle circle = new Circle(2);
        circle.CalculateArea();
        Rectangle rectangle = new Rectangle(3, 4);
        rectangle.CalculateArea();
        Triangle triangle = new Triangle(5, 6);
        triangle.CalculateArea();
        
    }
}
