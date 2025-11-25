// using System;
class ProgramC8
{
    public static void Run()
    {
        Console.WriteLine("Enter the amount in Indian Rupees: ");
        double ind = Convert.ToInt32(Console.ReadLine());

        double usd = ind*89.21;
        Console.WriteLine("IND: "+ ind + " USD: "+usd);
        double eur = ind*103.01;
        Console.WriteLine("IND: "+ ind + " EUR: "+eur);
        double gbp = ind*117.19;
        Console.WriteLine("IND: "+ ind + " GBP: "+gbp);
    }
}