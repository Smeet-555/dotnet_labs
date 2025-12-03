// // Create a class Employee that uses method overloading to display employee
// // information. One method should take only name, another should take
// // name and age, and another should take all three: name, age, and salary.
//
// using System;
//
// class Program4A2
// {
//
// public class Employee
// {
//     string name;
//     int age;
//     double salary;
//
//     public void setValue(string name)
//     {
//         this.name = name;
//         Console.WriteLine($"Name is set to : {this.name} ");
//     }
//
//     public void setValue(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//         Console.WriteLine($"Name is set to : {this.name} and age is : {this.age} ");
//     }
//     public void setValue(string name, int age , int salary)
//     {
//         this.name = name;
//         this.age = age;
//         this.salary = salary;
//         Console.WriteLine($"Name is set to : {this.name} and age is : {this.age} and the salary is : {this.salary} ");
//     }
//     
// }
//
//     public static void Run()
//     {
//         Employee employee1 = new Employee();
//         employee1.setValue("John");
//         Console.WriteLine("--------------------------");
//         Employee employee2 = new Employee();
//         employee2.setValue("John" , 30);
//         Console.WriteLine("---------------------------");
//         Employee employee3 = new Employee();
//         employee3.setValue("John" , 30 , 5555);
//     }
// }