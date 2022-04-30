using System;

namespace ConsoleApp1.Exceptions
{
    public class TriangleDoesntExistException : Exception
    {
        public TriangleDoesntExistException(string message)
        {
            Message = message;
        }
        
        public override string Message { get; }
    }
}