using System;

namespace ConsoleApp1.Lab4
{
    class LibraryItem
{
    protected string Title;
    protected string Author;
    

    public LibraryItem(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
    }
}

class Book : LibraryItem
{
    public int Pages;

    public Book(string title, string author, int pages)
        : base(title, author)
    {
        Pages = pages;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Book Details:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Pages: {Pages}");
    }
}

class Magazine : LibraryItem
{
    public int IssueNumber;

    public Magazine(string title, string author, int issueNumber)
        : base(title, author)
    {
        IssueNumber = issueNumber;
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine("Magazine Details:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Issue Number: {IssueNumber}");
    }
}

    class Program4C7
    {
        public static void Run()
    {
        LibraryItem book = new Book("C# in Depth", "Jon Skeet", 900);
        LibraryItem magazine = new Magazine("Shikshit Talks", "Shikhar Chaudhary", 120);

        book.DisplayInfo();
        Console.WriteLine();
        magazine.DisplayInfo();
        }
    }
}