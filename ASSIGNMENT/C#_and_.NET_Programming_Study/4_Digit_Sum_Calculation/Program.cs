using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Digit_Sum_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer:");
            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number) && number >= 0)
            {
                int sum = 0;
                int originalNumber = number;

                while (number > 0)
                {
                    int digit = number % 10;
                    sum += digit;
                    number /= 10;
                }

                Console.WriteLine("The sum of the digits in " + originalNumber + " is: " + sum);
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }

        }
    }
}

/*
 Enter a positive integer:
4578
The sum of the digits in 4578 is: 24
*/