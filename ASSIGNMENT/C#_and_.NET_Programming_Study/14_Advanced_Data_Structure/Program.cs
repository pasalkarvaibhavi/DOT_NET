using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_Advanced_Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(101, new Employee("Kunal", 50000));
            employees.Add(102, new Employee("Sameer", 70000));
            employees.Add(103, new Employee("Oliver", 65000));
            employees.Add(104, new Employee("Ava", 75000));
            employees.Add(105, new Employee("Ram", 55000));

            Console.WriteLine("All Employees:");
            DisplayEmployees(employees);

            Console.WriteLine("\nSearch Employee by ID:");
            Console.Write("Enter Employee ID: ");
            int searchId = Convert.ToInt32(Console.ReadLine());
            SearchEmployeeByID(employees, searchId);

            Console.WriteLine("\nFilter Employees by Salary (Above 60,000):");
            var highSalaryEmployees = employees.Values.Where(emp => emp.Salary > 60000);
            foreach (var emp in highSalaryEmployees)
                Console.WriteLine($"{emp.Name} earns {emp.Salary}");

            Console.WriteLine("\nSorted Employees by Salary (Ascending):");
            var sortedEmployees = employees.Values.OrderBy(emp => emp.Salary);
            foreach (var emp in sortedEmployees)
                Console.WriteLine($"{emp.Name} earns {emp.Salary}");

            Console.WriteLine("\nAdd a New Employee:");
            Console.Write("Enter Employee ID: ");
            int newId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            double newSalary = Convert.ToDouble(Console.ReadLine());
            employees[newId] = new Employee(newName, newSalary);
            Console.WriteLine("Employee added successfully!");

            Console.WriteLine("\nRemove an Employee:");
            Console.Write("Enter Employee ID to remove: ");
            int removeId = Convert.ToInt32(Console.ReadLine());
            if (employees.Remove(removeId))
                Console.WriteLine("Employee removed successfully!");
            else
                Console.WriteLine("Employee not found!");

            Console.WriteLine("\nFinal Employee List:");
            DisplayEmployees(employees);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void DisplayEmployees(Dictionary<int, Employee> employees)
        {
            foreach (var emp in employees)
                Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value.Name}, Salary: {emp.Value.Salary}");
        }

        static void SearchEmployeeByID(Dictionary<int, Employee> employees, int id)
        {
            if (employees.ContainsKey(id))
            {
                var emp = employees[id];
                Console.WriteLine($"Found: {emp.Name} earns {emp.Salary}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}

/*
 All Employees:
ID: 101, Name: Kunal, Salary: 50000
ID: 102, Name: Sameer, Salary: 70000
ID: 103, Name: Oliver, Salary: 65000
ID: 104, Name: Ava, Salary: 75000
ID: 105, Name: Ram, Salary: 55000

Search Employee by ID:
Enter Employee ID: 103
Found: Oliver earns 65000

Filter Employees by Salary (Above 60,000):
Sameer earns 70000
Oliver earns 65000
Ava earns 75000

Sorted Employees by Salary (Ascending):
Kunal earns 50000
Ram earns 55000
Oliver earns 65000
Sameer earns 70000
Ava earns 75000

Add a New Employee:
Enter Employee ID: 106
Enter Employee Name: Vaibhavi
Enter Employee Salary: 80000
Employee added successfully!

Remove an Employee:
Enter Employee ID to remove: 101
Employee removed successfully!

Final Employee List:
ID: 102, Name: Sameer, Salary: 70000
ID: 103, Name: Oliver, Salary: 65000
ID: 104, Name: Ava, Salary: 75000
ID: 105, Name: Ram, Salary: 55000
ID: 106, Name: Vaibhavi, Salary: 80000

Press any key to exit...
*/
