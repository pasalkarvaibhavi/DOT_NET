using System;

using System.IO;

namespace Q2_FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.bin"; 

            while (true)
            {
                Console.WriteLine("\n--- Binary File Operations ---");
                Console.WriteLine("1. Write to Binary File");
                Console.WriteLine("2. Read from Binary File");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WriteBinaryFile(filePath);
                        break;
                    case "2":
                        ReadBinaryFile(filePath);
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

      
        static void WriteBinaryFile(string filePath)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    Console.Write("Enter your Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your Salary: ");
                    double salary = Convert.ToDouble(Console.ReadLine());

                    writer.Write(name);
                    writer.Write(age);
                    writer.Write(salary);

                    Console.WriteLine("Data written to binary file successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ReadBinaryFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    string name = reader.ReadString();
                    int age = reader.ReadInt32();
                    double salary = reader.ReadDouble();

                    Console.WriteLine("\n--- Data Read from Binary File ---");
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Age: " + age);
                    Console.WriteLine("Salary: " + salary);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}