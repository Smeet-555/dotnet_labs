// Create a class Employee with members empID, empName, and salary.
// Initialize these values using a parameterized constructor and display them
// using a class method.


using System;

class Employee
{
    public int empId;
    public string empName;
    public double salary;

    public Employee(int empId, string empName, int salary)
    {
        this.empId = empId;
        this.empName = empName;
        this.salary = salary;
    }

    public void ShowData()
    {
        Console.WriteLine(empName + " " + empId + " " + salary);
    }
}

class Program3B6
{
    public static void Run()
    {
        Console.WriteLine("--------------------------------------");
        Employee[] employees = new Employee[3];
        employees[0] = new Employee(1, "Smit", 1000);
        employees[1] = new Employee(2, "XYZ", 200);
        employees[2] = new Employee(3, "ABC", 300);

        foreach (Employee employee in employees)
        {
            employee.ShowData();
        }
        
    }
}