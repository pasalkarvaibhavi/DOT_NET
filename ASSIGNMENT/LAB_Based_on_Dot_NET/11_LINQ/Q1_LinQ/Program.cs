using System;
using System.Linq;


namespace Q1_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 8, 21, 14, 3, 9, 2 };

            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              orderby num
                              select num;

            var oddNumbers = from num in numbers
                             where num % 2 != 0
                             orderby num
                             select num;

            var squaredNumbers = numbers.Select(num => num * num);
            var sum = numbers.Sum();
            var average = numbers.Average();
            var min = numbers.Min();
            var max = numbers.Max();
            var descendingOrder = numbers.OrderByDescending(num => num);

            Console.WriteLine("Even numbers sorted: " + string.Join(", ", evenNumbers));
            Console.WriteLine("Odd numbers sorted: " + string.Join(", ", oddNumbers));
            Console.WriteLine("Squared numbers: " + string.Join(", ", squaredNumbers));
            Console.WriteLine("Sum of numbers: " + sum);
            Console.WriteLine("Average of numbers: " + average);
            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
            Console.WriteLine("Numbers in descending order: " + string.Join(", ", descendingOrder));
        }
    }
}