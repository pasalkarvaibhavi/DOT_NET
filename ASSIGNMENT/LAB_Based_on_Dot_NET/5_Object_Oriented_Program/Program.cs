using System;

public interface IPrintable
{
    void PrintDetails();
}

public abstract class Employee : IPrintable
{
    public string Name { get; set; }
    public static int EmployeeCount;

    public Employee(string name)
    {
        Name = name;
        EmployeeCount++;
    }

    public abstract decimal CalculateSalary();

    public virtual void PrintDetails()
    {
        Console.WriteLine($"Employee: {Name}, Salary: {CalculateSalary()}");
    }
}

public class FullTimeEmployee : Employee
{
    public decimal BaseSalary { get; set; }

    public FullTimeEmployee(string name, decimal baseSalary) : base(name)
    {
        BaseSalary = baseSalary;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary;
    }
}

public class ContractEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public ContractEmployee(string name, decimal hourlyRate, int hoursWorked) : base(name)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}

public class Program
{
    public static void Main()
    {
        Employee emp1 = new FullTimeEmployee("Ram", 40000);
        emp1.PrintDetails();

        Employee emp2 = new ContractEmployee("Kusum", 50, 160);
        emp2.PrintDetails();

        Console.WriteLine("Total Employees: " + Employee.EmployeeCount);
    }
}

/*
Employee: Ram, Salary: 40000
Employee: Kusum, Salary: 8000
Total Employees: 2
*/