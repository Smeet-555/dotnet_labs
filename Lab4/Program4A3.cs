using System;

public class Person
{
    public string Name;          
    private string Password;     
    protected double Salary;     
    internal int Id;             

    public Person(string name, string password, double salary, int id)
    {
        Name = name;
        Password = password;
        Salary = salary;
        Id = id;
    }

    public void DisplayInsidePerson()
    {
        Console.WriteLine($"Name: {Name}");      
        Console.WriteLine($"Password: {Password}"); 
        Console.WriteLine($"Salary: {Salary}");   
        Console.WriteLine($"ID: {Id}");           
    }
}

class Employee : Person
{
    public Employee(string name, string password, double salary, int id)
        : base(name, password, salary, id)
    {
    }

    public void DisplayEmpInfo()
    {
        Console.WriteLine($"Name: {Name}");     
        // Console.WriteLine(Password);        //cannot be accessed as it is private 
        Console.WriteLine($"Salary: {Salary}"); 
        Console.WriteLine($"ID: {Id}");         
    }
}


class ExternalClass
{
    public void DisplayFromExternal(Person p)
    {
        Console.WriteLine($"Name: {p.Name}");  
        // Console.WriteLine(p.Password);    // due to private access specifier  
        // Console.WriteLine(p.Salary);        // due to protected access specifier
        Console.WriteLine($"ID: {p.Id}");      
    }
}

class Program4A3
{
    public static void Run()
    {
        Person person = new Person("Smit", "abc123", 50000, 101);
        Employee emp = new Employee("Rahul", "emp456", 70000, 102);
        ExternalClass ext = new ExternalClass();

        // Inside same class
        person.DisplayInsidePerson();

        // Inside derived class
        emp.DisplayEmpInfo();

        // From external class
        ext.DisplayFromExternal(person);
    }
}
