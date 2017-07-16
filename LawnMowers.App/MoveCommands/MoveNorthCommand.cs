using System;

namespace LawnMowers.App.MoveCommands
{
    public class MoveNorthCommand : IMoveCommand
    {
        public ICoordinates GetNextCoordinates(ICoordinates coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException(nameof(coordinates));
            }

            return new Coordinates(coordinates.X, coordinates.Y + 1, coordinates.Direction);
        }
    }
}