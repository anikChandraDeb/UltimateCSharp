using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP;

public class Product
{
    //Fields syntax: [access modifier] [modifier] [data type] [field name];
    //access modifier: public, private, protected, internal, protected internal, private protected
    //modifier: static, readonly, const
    public int Id;
    public string Name;
    public int Stock;
    public decimal Price;
    public string Description;
    public string Sku;
}

// Base class
public class Employee
{
    // -------------------------
    // Access Specifier Fields
    // -------------------------

    public string Name;                // Accessible everywhere
    private double Salary;             // Accessible only inside this class
    protected int Age;                 // Accessible in derived classes
    internal int EmployeeId;           // Accessible within same assembly
    protected internal string Department; // Same assembly OR derived class
    private protected string SecretCode;  // Derived class + same assembly

    // -------------------------
    // Field Modifiers
    // -------------------------

    public static int EmployeeCount = 0;      // Shared by all objects
    public readonly DateTime JoiningDate;     // Assigned once
    public const string CompanyName = "Tech Corp"; // Compile-time constant
    public volatile bool IsRunning;           // Used in multithreading

    // Constructor
    public Employee(string name, double salary, int age)
    {
        Name = name;
        Salary = salary;
        Age = age;
        JoiningDate = DateTime.Now;
        SecretCode = "EMP-SECRET";

        EmployeeCount++;
    }

    // Method to access private field
    public void ShowSalary()
    {
        Console.WriteLine($"Salary: {Salary}");
    }

    public void DisplayEmployee()
    {
        Console.WriteLine("\nEmployee Information:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Joining Date: {JoiningDate}");
        Console.WriteLine($"Company: {CompanyName}");
    }
}

// Derived class
public class Manager : Employee
{
    public Manager(string name, double salary, int age)
        : base(name, salary, age)
    {
    }

    public void ShowDerivedAccess()
    {
        Console.WriteLine("\nAccessing fields from derived class:");

        Console.WriteLine($"Name: {Name}");   // public
        Console.WriteLine($"Age: {Age}");     // protected
        Console.WriteLine($"Department: {Department}"); // protected internal
    }
}