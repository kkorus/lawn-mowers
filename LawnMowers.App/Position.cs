using LawnMowers.App.MoveCommandProvider;

namespace LawnMowers.App
{
    public class Position : IPosition
    {
        private readonly ILawn _lawn;

        private readonly IMoveCommandProvider _moveCommandProvider = new MoveCommandProvider.MoveCommandProvider();

        private ICoordinates _coordinates;

        public Position(ILawn lawn, ICoordinates coordinates)
        {
            _lawn = lawn;
            _coordinates = coordinates;
        }

        public string CurrentPosition => $"{_coordinates.X} {_coordinates.Y} {_coordinates.Direction}";

        public void Move()
        {
            var command = _moveCommandProvider.GetCommand(_coordinates.Direction);
            var newCoordinates = command.GetNextCoordinates(_coordinates);

            if (_lawn.AreCoordinatesValid(newCoordinates))
            {
                _coordinates = newCoordinates;
            }
        }

        public void TurnLeft()
        {
            if (_coordinates.Direction == Direction.N)
            {
                _coordinates.Direction = Direction.W;
            }
            else
            {
                _coordinates.Direction--;
            }
        }

        public void TurnRight()
        {
            if (_coordinates.Direction == Direction.W)
            {
                _coordinates.Direction = Direction.N;
            }
            else
            {
                _coordinates.Direction++;
            }
        }
    }
}