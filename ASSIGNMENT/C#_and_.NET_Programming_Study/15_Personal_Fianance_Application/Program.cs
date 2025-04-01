using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_Personal_Fianance_Application
{
    class Program
    {
        static double totalIncome = 0;
        static List<Expense> expenses = new List<Expense>();

        class Expense
        {
            public string Name { get; set; }
            public double Amount { get; set; }
            public string Category { get; set; }
        }

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Personal Finance Manager =====");
                Console.WriteLine("1. Set Income");
                Console.WriteLine("2. Add Expense");
                Console.WriteLine("3. View Expenses");
                Console.WriteLine("4. Delete Expense");
                Console.WriteLine("5. Generate Report");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SetIncome();
                        break;
                    case "2":
                        AddExpense();
                        break;
                    case "3":
                        ViewExpenses();
                        break;
                    case "4":
                        DeleteExpense();
                        break;
                    case "5":
                        GenerateReport();
                        break;
                    case "6":
                        Console.WriteLine("Exiting program... Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void SetIncome()
        {
            Console.Write("Enter your total monthly income: ");
            if (double.TryParse(Console.ReadLine(), out totalIncome) && totalIncome > 0)
            {
                Console.WriteLine("Income updated successfully!");
            }
            else
            {
                Console.WriteLine("Invalid income amount! Please enter a valid number.");
            }
        }

        static void AddExpense()
        {
            Console.Write("Enter Expense Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Expense Amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount! Please enter a positive number.");
                return;
            }

            Console.Write("Enter Category (Food, Transport, Bills, Shopping, Other): ");
            string category = Console.ReadLine();

            expenses.Add(new Expense { Name = name, Amount = amount, Category = category });
            Console.WriteLine("Expense added successfully!");
        }

        static void ViewExpenses()
        {
            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses recorded yet.");
                return;
            }

            Console.WriteLine("===== Expense List =====");
            foreach (var expense in expenses)
            {
                Console.WriteLine($"{expense.Name} - ${expense.Amount:F2} ({expense.Category})");
            }
        }

        static void DeleteExpense()
        {
            Console.Write("Enter Expense Name to Delete: ");
            string name = Console.ReadLine();
            var expenseToRemove = expenses.FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (expenseToRemove != null)
            {
                expenses.Remove(expenseToRemove);
                Console.WriteLine("Expense deleted successfully.");
            }
            else
            {
                Console.WriteLine("Expense not found.");
            }
        }

        static void GenerateReport()
        {
            double totalExpenses = expenses.Sum(e => e.Amount);
            double remainingBalance = totalIncome - totalExpenses;

            Console.WriteLine("\n===== Financial Report =====");
            Console.WriteLine($"Total Income: ${totalIncome:F2}");
            Console.WriteLine($"Total Expenses: ${totalExpenses:F2}");
            Console.WriteLine($"Remaining Balance: ${remainingBalance:F2}\n");

            Console.WriteLine("===== Expenses by Category =====");
            var categoryGroups = expenses.GroupBy(e => e.Category);
            foreach (var group in categoryGroups)
            {
                Console.WriteLine($"{group.Key}: ${group.Sum(e => e.Amount):F2}");
            }
        }
    }
}
