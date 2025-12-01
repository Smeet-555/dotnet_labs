using System;

namespace ConsoleApp1.Lab3
{
    public class Program3A3
    {
        public static void Run()
        {
            Console.WriteLine("Enter num1");
            double num1 = Convert.ToDouble(Console.ReadLine());  
            // int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            double num2 = Convert.ToDouble(Console.ReadLine());
            // int num2 = Convert.ToInt32(Console.ReadLine());
            
            // if we read the numbers in double and then if we divide any number by 0 , it will return 
            // infinite instead of Error from try-catch
            
            try
            
            {
                double result = num1/num2;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}