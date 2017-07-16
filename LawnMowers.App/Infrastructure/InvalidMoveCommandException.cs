using System;

namespace LawnMowers.App.Infrastructure
{
    public class InvalidMoveCommandException : InvalidCommandException
    {
        public InvalidMoveCommandException()
        {
        }

        public InvalidMoveCommandException(string message)
            : base(message)
        {
        }

        public InvalidMoveCommandException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}