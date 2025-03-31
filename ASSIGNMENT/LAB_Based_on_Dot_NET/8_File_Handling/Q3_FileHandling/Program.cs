using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Directory and File Information ---");
                Console.WriteLine("1. Get Directory Information");
                Console.WriteLine("2. Get File Information");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GetDirectoryInfo();
                        break;
                    case "2":
                        GetFileInfo();
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void GetDirectoryInfo()
        {
            Console.Write("\nEnter Directory Path: ");
            string dirPath = Console.ReadLine();

            if (Directory.Exists(dirPath))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
                Console.WriteLine("\n--- Directory Details ---");
                Console.WriteLine($"Full Path: {dirInfo.FullName}");
                Console.WriteLine($"Created On: {dirInfo.CreationTime}");
                Console.WriteLine($"Last Accessed: {dirInfo.LastAccessTime}");
                Console.WriteLine($"Last Modified: {dirInfo.LastWriteTime}");
                Console.WriteLine($"Attributes: {dirInfo.Attributes}");

                Console.WriteLine("\n--- Subdirectories ---");
                foreach (var dir in dirInfo.GetDirectories())
                {
                    Console.WriteLine(dir.Name);
                }

                Console.WriteLine("\n--- Files in Directory ---");
                foreach (var file in dirInfo.GetFiles())
                {
                    Console.WriteLine(file.Name);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }

        static void GetFileInfo()
        {
            Console.Write("\nEnter File Path: ");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine("\n--- File Details ---");
                Console.WriteLine($"File Name: {fileInfo.Name}");
                Console.WriteLine($"Full Path: {fileInfo.FullName}");
                Console.WriteLine($"Size: {fileInfo.Length} bytes");
                Console.WriteLine($"Created On: {fileInfo.CreationTime}");
                Console.WriteLine($"Last Accessed: {fileInfo.LastAccessTime}");
                Console.WriteLine($"Last Modified: {fileInfo.LastWriteTime}");
                Console.WriteLine($"Attributes: {fileInfo.Attributes}");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}