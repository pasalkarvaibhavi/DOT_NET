using System;


namespace _2_C_Language_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                while (true)
                {
                    Console.WriteLine("\n--- MENU ---");
                    Console.WriteLine("1. Check if a Number is a Palindrome (Using Recursion)");
                    Console.WriteLine("2. Check if a Number is a Palindrome (Without Recursion)");
                    Console.WriteLine("3. Calculate Square Root of a Number");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter a number: ");
                            string numStr = Console.ReadLine();
                            if (IsPalindromeRecursive(numStr, 0, numStr.Length - 1))
                                Console.WriteLine($"{numStr} is a Palindrome.");
                            else
                                Console.WriteLine($"{numStr} is NOT a Palindrome.");
                            break;

                        case "2":
                            Console.Write("Enter a number: ");
                            string numStr2 = Console.ReadLine();
                            if (IsPalindromeNonRecursive(numStr2))
                                Console.WriteLine($"{numStr2} is a Palindrome.");
                            else
                                Console.WriteLine($"{numStr2} is NOT a Palindrome.");
                            break;

                        case "3":
                            Console.Write("Enter a number: ");
                            try
                            {
                                double number = Convert.ToDouble(Console.ReadLine());
                                if (number < 0)
                                    throw new Exception("Cannot calculate square root of a negative number.");
                                Console.WriteLine($"Square root: {Math.Sqrt(number):F2}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                            break;

                        case "4":
                            Console.WriteLine("Exiting program...");
                            return;

                        default:
                            Console.WriteLine("Invalid choice! Please enter 1, 2, 3, or 4.");
                            break;
                    }
                }
            }

            static bool IsPalindromeRecursive(string str, int left, int right)
            {
                if (left >= right)
                    return true;
                if (str[left] != str[right])
                    return false;
                return IsPalindromeRecursive(str, left + 1, right - 1);
            }

            static bool IsPalindromeNonRecursive(string str)
            {
                int left = 0, right = str.Length - 1;
                while (left < right)
                {
                    if (str[left] != str[right])
                        return false;
                    left++;
                    right--;
                }
                return true;
            }
    }
}

/*
 
--- MENU ---
1. Check if a Number is a Palindrome (Using Recursion)
2. Check if a Number is a Palindrome (Without Recursion)
3. Calculate Square Root of a Number
4. Exit
Enter your choice: 1
Enter a number: 456
456 is NOT a Palindrome.

--- MENU ---
1. Check if a Number is a Palindrome (Using Recursion)
2. Check if a Number is a Palindrome (Without Recursion)
3. Calculate Square Root of a Number
4. Exit
Enter your choice: 1
Enter a number: 444
444 is a Palindrome.

--- MENU ---
1. Check if a Number is a Palindrome (Using Recursion)
2. Check if a Number is a Palindrome (Without Recursion)
3. Calculate Square Root of a Number
4. Exit
Enter your choice: 3
Enter a number: 56
Square root: 7.48

--- MENU ---
1. Check if a Number is a Palindrome (Using Recursion)
2. Check if a Number is a Palindrome (Without Recursion)
3. Calculate Square Root of a Number
4. Exit

*/