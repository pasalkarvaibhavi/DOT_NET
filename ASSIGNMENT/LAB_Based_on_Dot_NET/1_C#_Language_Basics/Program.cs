using System;

namespace _1_C__Language_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Swap First and Last Characters of a String");
                Console.WriteLine("2. Sum of Digits of a Number");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter a string: ");
                        string input = Console.ReadLine();
                        Console.WriteLine("Modified string: " + SwapFirstLast(input));
                        break;

                    case "2":
                        Console.Write("Enter a number: ");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            Console.WriteLine("Sum of digits: " + SumOfDigits(number));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please enter a valid number.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                        break;
                }
            }
        }

        static string SwapFirstLast(string str)
        {
            if (str.Length < 2)
                return str;

            char[] chars = str.ToCharArray();
            char temp = chars[0];
            chars[0] = chars[chars.Length - 1];
            chars[chars.Length - 1] = temp;

            return new string(chars);
        }

        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}


/*Output:
 
--- MENU ---
1. Swap First and Last Characters of a String
2. Sum of Digits of a Number
3. Exit
Enter your choice: 1
Enter a string: Vaibhavi
Modified string: iaibhavV

--- MENU ---
1. Swap First and Last Characters of a String
2. Sum of Digits of a Number
3. Exit
Enter your choice: 2
Enter a number: 4137
Sum of digits: 15

--- MENU ---
1. Swap First and Last Characters of a String
2. Sum of Digits of a Number
3. Exit
Enter your choice:
*/