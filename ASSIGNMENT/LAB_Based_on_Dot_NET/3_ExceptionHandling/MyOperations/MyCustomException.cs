using System;

namespace MyOperations
{
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; }

        public MyCustomException(int errorCode, string errorDescription)
        {
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
        }

        public override string ToString()
        {
            return $"Error Code: {ErrorCode}, Description: {ErrorDescription}";
        }
    }
}
