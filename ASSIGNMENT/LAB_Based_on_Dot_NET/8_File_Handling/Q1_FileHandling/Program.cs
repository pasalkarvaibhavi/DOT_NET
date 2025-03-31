using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace Q1_FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String filePath = "sample.txt";
            while (true)
            {
                Console.WriteLine("\n--- File Operations ---");
                Console.WriteLine("1. Write to File");
                Console.WriteLine("2. Read from File");
                Console.WriteLine("3. Append to File");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter text to write to the file: ");
                        string writeText = Console.ReadLine();
                        File.WriteAllText(filePath, writeText);
                        Console.WriteLine("Text written successfully.");
                        break;

                    case "2":
                        if (File.Exists(filePath))
                        {
                            string readText = File.ReadAllText(filePath);
                            Console.WriteLine("\n--- File Content ---");
                            Console.WriteLine(readText);
                        }
                        else
                        {
                            Console.WriteLine("File does not exist.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter text to append to the file: ");
                        string appendText = Console.ReadLine();
                        File.AppendAllText(filePath, appendText + Environment.NewLine);
                        Console.WriteLine("Text appended successfully.");
                        break;

                    case "4":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
