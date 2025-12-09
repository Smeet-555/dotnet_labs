using System;
interface IPrintable
{
    void PrintDetails();
}

class Books : IPrintable
{
    public void PrintDetails()
    {
        Console.WriteLine("Book: 'The Great Gatsby' by F. Scott Fitzgerald");
    }
}

class Magazine : IPrintable
{
    public void PrintDetails()
    {
        Console.WriteLine("Magazine: 'National Geographic' - Science Edition");
    }
}

class Program5B5
{
    static void Run()
    {
        IPrintable printable;

        printable = new Books();
        printable.PrintDetails();

        printable = new Magazine();
        printable.PrintDetails();
    }
}
