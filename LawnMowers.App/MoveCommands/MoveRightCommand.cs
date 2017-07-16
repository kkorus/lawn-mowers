using System;

namespace LawnMowers.App.MoveCommands
{
    public class MoveRightCommand : IMoveCommand
    {
        public ICoordinates GetNextCoordinates(ICoordinates coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException(nameof(coordinates));
            }

            return new Coordinates(coordinates.X + 1, coordinates.Y, coordinates.Direction);
        }
    }
}