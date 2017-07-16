using System;

namespace LawnMowers.App.Infrastructure
{
    public class InvalidCommandException : LawnMowerException
    {
        public InvalidCommandException()
        {
        }

        public InvalidCommandException(string message)
            : base(message)
        {
        }

        public InvalidCommandException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}