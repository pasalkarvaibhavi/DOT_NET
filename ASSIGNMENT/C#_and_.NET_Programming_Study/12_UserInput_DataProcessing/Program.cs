using System;

namespace _12_UserInput_DataProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Input and Data Processing Demo");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine().Trim();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age;
            if (!int.TryParse(ageInput, out age) || age < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number for age.");
                return;
            }

            Console.Write("Enter your height in meters (e.g., 1.75): ");
            string heightInput = Console.ReadLine();
            double height;
            if (!double.TryParse(heightInput, out height) || height <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number for height.");
                return;
            }

            Console.Write("Enter your favorite color (red, blue, green): ");
            string color = Console.ReadLine().ToLower().Trim();
            if (color != "red" && color != "blue" && color != "green")
            {
                Console.WriteLine("Invalid color choice.");
                return;
            }

            Console.WriteLine("\n--- User Details ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height} meters");
            Console.WriteLine($"Favorite Color: {char.ToUpper(color[0]) + color.Substring(1)}");

            Console.Write("Enter a command (start, stop, exit): ");
            string command = Console.ReadLine().ToLower().Trim();
            switch (command)
            {
                case "start":
                    Console.WriteLine("The process has started.");
                    break;
                case "stop":
                    Console.WriteLine("The process has stopped.");
                    break;
                case "exit":
                    Console.WriteLine("Exiting the application...");
                    break;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }

            Console.WriteLine("Thank you! Press any key to exit...");
            Console.ReadKey();
        }
    }
}
