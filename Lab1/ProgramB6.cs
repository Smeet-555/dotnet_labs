using System;

class ProgramB6
{
    public static void Run()
    {
        Console.WriteLine("Enter the shape to calculate are and perimeter");
        Console.WriteLine("(1 for square , 2 for rectangle , 3 for triangle)");
        int shape = Convert.ToInt32(Console.ReadLine());

        switch (shape)
        {
            case 1:
            Console.WriteLine("Enter the length of side of square: ");
            int side = Convert.ToInt32(Console.ReadLine());
            int area = side*side;
            int perimeter = 4*side;
            Console.WriteLine("The area of square is: " + area);
            Console.WriteLine("The perimeter of square is: " + perimeter);
            break;

            case 2:
            Console.WriteLine("Enter the  width of rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of rectangle: ");
            int width = Convert.ToInt32(Console.ReadLine());
            int area_rectangle = length*width;
            int perimeter_rectangle = 2*(length+width);
            Console.WriteLine("The area of rectangle is: " + area_rectangle);
            Console.WriteLine("The perimeter of rectangle is: " + perimeter_rectangle);
            break;

            case 3:
            Console.WriteLine("Enter the length of 1st side of triangle: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of 2nd side of triangle: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of 3rd side of triangle: ");
            int c = Convert.ToInt32(Console.ReadLine());
            
            double s = (a+b+c)/2;

            double area_triangle = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            Console.WriteLine("The area of triangle is: " + area_triangle);
            Console.WriteLine("The perimeter of triangle is: " + (2*s));
            break;
        }
    }
}