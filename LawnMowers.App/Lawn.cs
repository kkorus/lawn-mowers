using System;

namespace LawnMowers.App
{
    public class Lawn : ILawn
    {
        private readonly int _height;

        private readonly int _width;

        public Lawn() : this(5, 5)
        {
        }

        public Lawn(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public bool AreCoordinatesValid(ICoordinates position)
        {
            if (position == null)
            {
                throw new ArgumentNullException(nameof(position));
            }

            return (position.X >= 0 && position.Y >= 0 && position.X <= _width && position.Y <= _height);
        }
    }
}