using System;
using MyOperations;

namespace ExceptionHandlingApp
{   class Program
    {
        static void Main(string[] args)
        {
            Operations ops = new Operations();
            try
            {
                int result = ops.Divide(10, 0);
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                int[] arr = { 1, 2, 3 };
                int value = ops.GetElement(arr, 5);
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
