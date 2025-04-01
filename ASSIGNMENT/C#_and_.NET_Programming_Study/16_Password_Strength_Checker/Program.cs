using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _16_Password_Strength_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Password Strength Checker =====");

            while (true)
            {
                Console.Write("Enter a password to check (or type 'exit' to quit): ");
                string password = Console.ReadLine();

                if (password.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting program... Goodbye!");
                    break;
                }

                string strength = CheckPasswordStrength(password);
                Console.WriteLine($"Password Strength: {strength}\n");
            }
        }

        static string CheckPasswordStrength(string password)
        {
            if (password.Length < 8)
                return "Weak (Too Short - Minimum 8 characters required)";

            int score = 0;

            if (Regex.IsMatch(password, @"[a-z]")) score++;
            if (Regex.IsMatch(password, @"[A-Z]")) score++;
            if (Regex.IsMatch(password, @"\d")) score++;
            if (Regex.IsMatch(password, @"[\W_]")) score++;

            switch (score)
            {
                case 4: return "Strong (Great mix of characters)";
                case 3: return "Medium (Consider adding more variety)";
                case 2: return "Weak (Needs uppercase, digits, or special characters)";
                default: return "Very Weak (Too simple)";
            }
        }
    }
}