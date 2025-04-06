using System;

namespace MyOperations
{
    public class Operations
    {
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(101, "Attempted to divide by zero.");
            }
        }

        public int GetElement(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(102, "Index is out of the array bounds.");
            }
        }
    }
}
