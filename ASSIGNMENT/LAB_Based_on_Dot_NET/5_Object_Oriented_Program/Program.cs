using System;

public interface IPrintable
{
    void PrintDetails();
}

public abstract class Employee : IPrintable
{
    public string Name { get; set; }
    public static int EmployeeCount;

    static Employee()
    {
        EmployeeCount = 0;
        Console.WriteLine("Employee static constructor: EmployeeCount initialized.");
    }

    public Employee(string name)
    {
        Name = name;
        EmployeeCount++;
    }

    public abstract decimal CalculateSalary();

    public virtual void PrintDetails()
    {
        Console.WriteLine("Employee: " + Name + ", Salary: " + CalculateSalary());
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

    public override void PrintDetails()
    {
        Console.WriteLine("Full-Time Employee: " + Name + ", Salary: " + CalculateSalary());
    }
}

public class ContractEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    private ContractEmployee(string name, decimal hourlyRate, int hoursWorked) : base(name)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public static ContractEmployee CreateContractEmployee(string name, decimal hourlyRate, int hoursWorked)
    {
        if (hourlyRate < 0 || hoursWorked < 0)
        {
            throw new ArgumentException("Hourly rate and hours worked must be non-negative.");
        }
        return new ContractEmployee(name, hourlyRate, hoursWorked);
    }

    public override decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public override void PrintDetails()
    {
        Console.WriteLine("Contract Employee: " + Name + ", Hours Worked: " + HoursWorked + ", Salary: " + CalculateSalary());
    }
}

public class Program
{
    public static void Main()
    {
        Employee emp1 = new FullTimeEmployee("Ram", 40000);
        emp1.PrintDetails();

        Employee emp2 = ContractEmployee.CreateContractEmployee("Kusum", 50, 160);
        emp2.PrintDetails();

        Console.WriteLine("Total Employees: " + Employee.EmployeeCount);
        
    }
}

/*
 Employee static constructor: EmployeeCount initialized.
Full-Time Employee: Ram, Salary: 40000
Contract Employee: Kusum, Hours Worked: 160, Salary: 8000
Total Employees: 2
*/