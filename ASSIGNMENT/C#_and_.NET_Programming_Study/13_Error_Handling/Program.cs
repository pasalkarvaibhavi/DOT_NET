using System;
using System.IO;

namespace _13_Error_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Error Handling Example");

                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                if (number < 0)
                {
                    throw new ArgumentException("Number cannot be negative.");
                }

                Console.WriteLine($"Square of {number} is {number * number}");

                ReadFileContent("sample.txt");

                Console.WriteLine("Program executed successfully.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid number format. Please enter a valid integer.");
                Console.WriteLine("Exception Details: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: File not found.");
                Console.WriteLine("Exception Details: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine("Exception Details: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for using the program.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void ReadFileContent(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("\nFile Content:\n" + content);
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException("The file could not be read.", ex);
            }
        }
    }
}
