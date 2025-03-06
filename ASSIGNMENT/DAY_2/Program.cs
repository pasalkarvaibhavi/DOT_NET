//ASSIGNMENT 2

using System;
using System.Collections.Generic;

interface ICalculator
{
    double Add(double a, double b);
    double Subtract(double a, double b);
    double Multiply(double a, double b);
    double Divide(double a, double b);
    double Percentage(double value, double total);
    double MultipleSum(List<double> numbers);
    double MultipleSubtract(List<double> numbers);
}

class Calculator : ICalculator
{
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;
    public double Divide(double a, double b) => b == 0 ? double.NaN : a / b;
    public double Percentage(double value, double total) => total == 0 ? double.NaN : (value / total) * 100;

    public double MultipleSum(List<double> numbers)
    {
        double sum = 0;
        foreach (var num in numbers) sum += num;
        return sum;
    }

    public double MultipleSubtract(List<double> numbers)
    {
        if (numbers.Count == 0) return 0;
        double result = numbers[0];
        for (int i = 1; i < numbers.Count; i++) result -= numbers[i];
        return result;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("\n============================");
        Console.WriteLine("  Student's Simple Calculator ");
        Console.WriteLine("============================\n");

        Calculator calc = new Calculator();
        while (true)
        {
            Console.WriteLine("\nCalculator Menu:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Percentage");
            Console.WriteLine("6. Multiple Sum");
            Console.WriteLine("7. Multiple Subtract");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 8) break;

            if (choice >= 1 && choice <= 5)
            {
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = choice switch
                {
                    1 => calc.Add(num1, num2),
                    2 => calc.Subtract(num1, num2),
                    3 => calc.Multiply(num1, num2),
                    4 => calc.Divide(num1, num2),
                    5 => calc.Percentage(num1, num2),
                    _ => 0
                };
                Console.WriteLine("Result: " + result);
            }
            else if (choice == 6 || choice == 7)
            {
                List<double> numbers = new List<double>();
                Console.Write("Enter numbers separated by space: ");
                string[] input = Console.ReadLine().Split();
                foreach (var item in input) numbers.Add(double.Parse(item));

                double result = choice == 6 ? calc.MultipleSum(numbers) : calc.MultipleSubtract(numbers);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
        Console.WriteLine("\nGoodbye!");
    }
}

/*============================
  Student's Simple Calculator
============================


Calculator Menu:
1. Add
2. Subtract
3. Multiply
4. Divide
5. Percentage
6. Multiple Sum
7. Multiple Subtract
8. Exit
Enter your choice: 1
Enter first number: 10
Enter second number: 50
Result: 60

Calculator Menu:
1. Add
2. Subtract
3. Multiply
4. Divide
5. Percentage
6. Multiple Sum
7. Multiple Subtract
8. Exit
Enter your choice: 2
Enter first number: 62
Enter second number: 41
Result: 21

Calculator Menu:
1. Add
2. Subtract
3. Multiply
4. Divide
5. Percentage
6. Multiple Sum
7. Multiple Subtract
8. Exit
Enter your choice: 3
Enter first number: 45
Enter second number: 7
Result: 315

Calculator Menu:
1. Add
2. Subtract
3. Multiply
4. Divide
5. Percentage
6. Multiple Sum
7. Multiple Subtract
8. Exit
Enter your choice: 4
Enter first number: 45
Enter second number: 9
Result: 5

Calculator Menu:
1. Add
2. Subtract
3. Multiply
4. Divide
5. Percentage
6. Multiple Sum
7. Multiple Subtract
8. Exit
Enter your choice: 5
Enter first number: 15
Enter second number: 90
Result: 16.666666666666664

Calculator Menu:
1. Add
2. Subtract
3. Multiply
4. Divide
5. Percentage
6. Multiple Sum
7. Multiple Subtract
8. Exit
Enter your choice: 6
Enter numbers separated by space: 4 4 4 4
Result: 16

Calculator Menu:
1. Add
2. Subtract
3. Multiply
4. Divide
5. Percentage
6. Multiple Sum
7. Multiple Subtract
8. Exit
Enter your choice: 7
Enter numbers separated by space: 4 2 7 3
Result: -8

Calculator Menu:
1. Add
2. Subtract
3. Multiply
4. Divide
5. Percentage
6. Multiple Sum
7. Multiple Subtract
8. Exit
Enter your choice: 8

Goodbye!
*/
