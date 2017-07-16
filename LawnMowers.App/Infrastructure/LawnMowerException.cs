using System;

namespace LawnMowers.App.Infrastructure
{
    public class LawnMowerException : Exception
    {
        public LawnMowerException()
        {
        }

        public LawnMowerException(string message)
            : base(message)
        {
        }

        public LawnMowerException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}