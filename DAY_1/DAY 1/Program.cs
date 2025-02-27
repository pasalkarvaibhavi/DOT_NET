using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{

    //static List<string> todos = new List<string>();
    static void Main()
    {


        // Q.(1) Hello World Program

        //Console.WriteLine("Hello World!");
        //Output:Hello World!


        //Q.(2)Basic User Input and Output

        //Console.Write("Enter your name:");
        //String name = Console.ReadLine();
        //Console.WriteLine($"Hello,{name}");

        //Output:
        //Enter your name: Vaibhavi
        //Hello, Vaibhavi


        //Q.3 Basic Calculator

        //Console.WriteLine("**Basic Calculator**");
        //Console.Write("Enter 1st number: ");
        //double num1 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Enter 2nd number: ");
        //double num2 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine($"Sum: {num1 + num2}");
        //Console.WriteLine($"Difference: {num1 - num2}");
        //Console.WriteLine($"Product: {num1 * num2}");
        //Console.WriteLine($"Quotient: {num1 / num2}");

        //Output:
        //**Basic Calculator**
        //Enter 1st number: 15
        //Enter 2nd number: 8
        //Sum: 23
        //Difference: 7
        //Product: 120
        //Quotient: 1.875


        //Q.4 Temperature Converter


        //Celcius to Fahrenheit conversion

        //Console.Write("Enter temperature in Celsius: ");
        //double celsius = Convert.ToDouble(Console.ReadLine());
        //double fahrenheit = (celsius * 9 / 5) + 32;
        //Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

        //Output:
        //Enter temperature in Celsius: 45
        // 45°C = 113°F


        //Fahrenheit to Celcius conversion

        //Console.Write("Enter temperature in Fahrenheit: ");
        //double fahrenheit = Convert.ToDouble(Console.ReadLine());
        //double celcius = (fahrenheit - 32) * 5 / 9;
        //Console.WriteLine($"{fahrenheit}°C = {celcius}°F");

        //Ouput:
        //Enter temperature in Fahrenheit: 113
        //113°C = 45°F


        //Q.5 Number Guessing Game

        //Random random = new Random();
        //int targetNumber = random.Next(1, 101);
        //int attempts = 0;
        //while (true)
        //{
        //    Console.Write("Guess the number (1-100): ");
        //    int guess = Convert.ToInt32(Console.ReadLine());
        //    attempts++;
        //    if (guess == targetNumber)
        //    {
        //        Console.WriteLine($"Correct! You took {attempts} attempts.");
        //        break;
        //    }
        //    else if (guess < targetNumber)
        //    {
        //        Console.WriteLine("Too low!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Too high!");
        //    }
        //}

        //Output:
        //Guess the number (1-100): 45
        //        Too low!
        //        Guess the number(1 - 100): 68
        //Too high!
        //Guess the number(1 - 100): 55
        //Too high!
        //Guess the number(1 - 100): 50
        //Too low!
        //Guess the number(1 - 100): 53
        //Too high!
        //Guess the number(1 - 100): 54
        //Too high!
        //Guess the number(1 - 100): 51
        //Too low!
        //Guess the number(1 - 100): 52
        //Correct! You took 8 attempts.


        //Q.5 Simple Array Operation

        //Console.Write("Enter the total nubmer of values:? ");
        //int size = Convert.ToInt32(Console.ReadLine());
        //int[] numbers = new int[size];
        //for (int i = 0; i < size; i++)
        //{
        //    Console.Write($"Enter number {i + 1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine($"Sum: {numbers.Sum()}");
        //Console.WriteLine($"Average: {numbers.Average()}");
        //Console.WriteLine($"Maximum: {numbers.Max()}");
        //Console.WriteLine($"Minimum: {numbers.Min()}");

        //OutPut:
        //How many numbers do you want to enter ? 4
        //Enter number 1: 54
        //Enter number 2: 7
        //Enter number 3: 5
        //Enter number 4: 19
        //Sum: 85
        //Average: 21.25
        //Maximum: 54
        //Minimum: 5

        //Q.7 Word Counter

        //Console.WriteLine("Enter a sentence:");
        //string sentence = Console.ReadLine();
        //int wordCount = sentence.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Length;
        //int charCount = sentence.Length;
        //Console.WriteLine($"Word count: {wordCount}");
        //Console.WriteLine($"Character count: {charCount}");

        //Output:
        //Enter a sentence:
        //hi my name is Vaibhavi
        //Word count: 5
        //Character count: 22


        //Q.8 Simple File Operations

        //Console.WriteLine("Enter text to save to file:");
        //string content = Console.ReadLine();
        //File.WriteAllText("TextFile.txt", content);
        //Console.WriteLine("Text saved to file!");
        //Console.WriteLine("\nReading from file:");
        //string readContent = File.ReadAllText("TextFile.txt");
        //Console.WriteLine(readContent);

        //Output

        //Enter text to save to file:
        //hi there
        //Text saved to file!

        //Reading from file:
        //hi there


        //Q.9 

        //while(true)
        //   {
        //    Console.WriteLine("\n1. Add Todo");
        //    Console.WriteLine("2. View Todos");
        //    Console.WriteLine("3. Remove Todo");
        //    Console.WriteLine("4. Exit");
        //    Console.Write("Choose option: ");
        //    string choice = Console.ReadLine();
        //    switch (choice)
        //    {
        //        case "1":
        //                Console.Write("Enter todo: ");
        //                todos.Add(Console.ReadLine());
        //                break;
        //        case "2":

        //                for (int i = 0; i < todos.Count; i++)
        //                {
        //                    Console.WriteLine($"{i + 1}. {todos[i]}");
        //                }
        //                break;

        //        case "3":
        //                Console.Write("Enter index to remove: ");
        //                int index = Convert.ToInt32(Console.ReadLine()) - 1;
        //                todos.RemoveAt(index);
        //                break;
        //                case "4":
        //                return;
        //        }
        //        }


        //            Output:

        //            1.Add Todo
        //            2.View Todos
        //            3.Remove Todo
        //            4.Exit
        //            Choose option: 1
        //            Enter todo: To create meeting at 4 pm.

        //            1.Add Todo
        //            2.View Todos
        //            3.Remove Todo
        //            4.Exit
        //            Choose option: 2
        //            1.To create meeting at 4 pm.

        //            1.Add Todo
        //            2.View Todos
        //            3.Remove Todo
        //            4.Exit
        //            Choose option: 1
        //            Enter todo: Count the items in bag.

        //            1.Add Todo
        //            2.View Todos
        //            3.Remove Todo
        //            4.Exit
        //            Choose option: 2
        //            1.To create meeting at 4 pm.
        //            2.Count the items in bag.

        //            1.Add Todo
        //            2.View Todos
        //            3.Remove Todo
        //            4.Exit
        //            Choose option: 3
        //            Enter index to remove: 1

        //            1.Add Todo
        //            2.View Todos
        //            3.Remove Todo
        //            4.Exit
        //            Choose option: 2
        //            1.Count the items in bag.

        //            1.Add Todo
        //            2.View Todos
        //            3.Remove Todo
        //            4.Exit
        //            Choose option: 4


        //Q.10 

        //while (true)
        //{
        //    Console.WriteLine("\nCalculator Menu:");
        //    Console.WriteLine("1. Add");
        //    Console.WriteLine("2. Subtract");
        //    Console.WriteLine("3. Multiply");
        //    Console.WriteLine("4. Divide");
        //    Console.WriteLine("5. Exit");
        //    Console.Write("Choose operation: ");
        //    string choice = Console.ReadLine();
        //    if (choice == "5") break;
        //    Console.Write("Enter first number: ");
        //    double num1 = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Enter second number: ");
        //    double num2 = Convert.ToDouble(Console.ReadLine());
        //    switch (choice)
        //    {
        //        case "1":
        //            Console.WriteLine($"Result: {Add(num1, num2)}");
        //            break;
        //        case "2":
        //            Console.WriteLine($"Result: {Subtract(num1, num2)}");
        //            break;
        //        case "3":
        //            Console.WriteLine($"Result: {Multiply(num1, num2)}");
        //            break;
        //        case "4":
        //            Console.WriteLine($"Result: {Divide(num1, num2)}");
        //            break;
        //                }
        //            }
        //        }
        //        static double Add(double a, double b) => a + b;
        //        static double Subtract(double a, double b) => a - b;
        //        static double Multiply(double a, double b) => a * b;
        //        static double Divide(double a, double b) => b != 0 ? a / b : double.NaN;

        //Q.10 Improved One


        //        Console.WriteLine("        Simple Calculator     ");
        //        Console.WriteLine("===================================");


        //        while (true)
        //        {
        //            Console.WriteLine("\n Choose an operation:");
        //            Console.WriteLine("1)Add");
        //            Console.WriteLine("2)Subtract");
        //            Console.WriteLine("3)Multiply");
        //            Console.WriteLine("4)Divide");
        //            Console.WriteLine("5)Modulus");
        //            Console.WriteLine("6)Exponentiation");
        //            Console.WriteLine("7)Exit");
        //            Console.Write("Enter your choice: ");

        //            string choice = Console.ReadLine();

        //            if (choice == "7")
        //            {

        //                Console.WriteLine("\nExiting... Thank you for using the calculator!");
        //                break;
        //            }

        //            double num1, num2;
        //            if (!GetNumber("\n Enter first number: ", out num1) || !GetNumber(" Enter second number: ", out num2))
        //            {
        //                DisplayError("Invalid input. Please enter valid numbers.");
        //                continue;
        //            }

        //            Console.WriteLine("\n-------------------------------------");
        //            Console.Write("Result: ");

        //            switch (choice)
        //            {
        //                case "1":
        //                    Console.WriteLine(Add(num1, num2));
        //                    break;
        //                case "2":
        //                    Console.WriteLine(Subtract(num1, num2));
        //                    break;
        //                case "3":
        //                    Console.WriteLine(Multiply(num1, num2));
        //                    break;
        //                case "4":
        //                    Console.WriteLine(Divide(num1, num2));
        //                    break;
        //                case "5":
        //                    Console.WriteLine(Modulus(num1, num2));
        //                    break;
        //                case "6":
        //                    Console.WriteLine(Exponentiate(num1, num2));
        //                    break;
        //                default:
        //                    DisplayError("Invalid choice! Please select a valid option.");
        //                    break;
        //            }
        //            Console.WriteLine("-------------------------------------");

        //        }
        //    }

        //    static bool GetNumber(string prompt, out double number)
        //    {
        //        Console.Write(prompt);
        //        return double.TryParse(Console.ReadLine(), out number);
        //    }

        //    static void DisplayError(string message)
        //    {

        //        Console.WriteLine($"{message}");

        //    }

        //    static double Add(double a, double b) => a + b;
        //    static double Subtract(double a, double b) => a - b;
        //    static double Multiply(double a, double b) => a * b;
        //    static string Divide(double a, double b) => b != 0 ? $"{a / b}" : "Error: Division by zero!";
        //    static double Modulus(double a, double b) => b != 0 ? a % b : double.NaN;
        //    static double Exponentiate(double a, double b) => Math.Pow(a, b);

        //    Output
        //                Simple Calculator
        //===================================

        // Choose an operation:
        //1)Add
        //2)Subtract
        //3)Multiply
        //4)Divide
        //5)Modulus
        //6)Exponentiation
        //7)Exit
        //Enter your choice: 1

        // Enter first number: 2
        // Enter second number: 3

        //-------------------------------------
        //Result: 5
        //-------------------------------------

        // Choose an operation:
        //1)Add
        //2)Subtract
        //3)Multiply
        //4)Divide
        //5)Modulus
        //6)Exponentiation
        //7)Exit
        //Enter your choice: 2

        // Enter first number: 2
        // Enter second number: 1

        //-------------------------------------
        //Result: 1
        //-------------------------------------

        // Choose an operation:
        //1)Add
        //2)Subtract
        //3)Multiply
        //4)Divide
        //5)Modulus
        //6)Exponentiation
        //7)Exit
        //Enter your choice: 6

        // Enter first number: 5
        // Enter second number: 4

        //-------------------------------------
        //Result: 625
        //-------------------------------------

        // Choose an operation:
        //1)Add
        //2)Subtract
        //3)Multiply
        //4)Divide
        //5)Modulus
        //6)Exponentiation
        //7)Exit
        //Enter your choice: 7

        //Exiting... Thank you for using the calculator!


        //HomeWork Question

        //1)Type Casting

        //Console.Write("Enter Input String: ");
        //string input = Console.ReadLine();

        //if (int.TryParse(input, out int intValue))
        //    Console.WriteLine($"Integer: {intValue}");
        //else
        //    Console.WriteLine("Not a valid Integer.");

        //if (double.TryParse(input, out double doubleValue))
        //    Console.WriteLine($"Double: {doubleValue}");
        //else
        //    Console.WriteLine("Not a valid Double.");

        //if (bool.TryParse(input, out bool boolValue))
        //    Console.WriteLine($"Boolean: {boolValue}");
        //else
        //    Console.WriteLine("Not a valid Boolean.");

        //if (DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateValue))
        //    Console.WriteLine($"DateTime: {dateValue}");
        //else
        //    Console.WriteLine("Not a valid DateTime (Expected format: yyyy-MM-dd).");


        //2)

        //Console.Write("Enter a string: ");
        //string str = Console.ReadLine();

        //string newStr = string.Join("*", str.ToCharArray());

        //char letter = 'l';
        //int count = 0;
        //string positions = "";

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == letter)
        //        {
        //            count++;
        //            positions += i + " ";
        //        }
        //    }

        //    Console.WriteLine("\nNew String: " + newStr);
        //    Console.WriteLine($"\n{letter} appears {count} times at positions: {positions.Trim()}");
        //}

        //Output:

        //Enter a string: hello

        //New String: h*e*l*l*o

        //l appears 2 times at positions: 2 3


        //Q.3)

        //Console.WriteLine("Enter text to append to file:");
        //string content = Console.ReadLine();

        //File.AppendAllText("TextFile1.txt", content + Environment.NewLine);

        //Console.WriteLine("Text appended to file!");

        //Console.WriteLine("\nReading from file:");
        //string readContent = File.ReadAllText("TextFile1.txt");
        //Console.WriteLine(readContent);

        //Output:
        //Enter text to append to file:
        //This is Second Line
        //Text appended to file!

        //Reading from file:
        //This is the 1st Line.
        //This is Second Line


    }
}




