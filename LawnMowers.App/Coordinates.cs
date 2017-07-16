namespace LawnMowers.App
{
    public class Coordinates : ICoordinates
    {
        public Coordinates(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public Direction Direction { get; set; }
    }
}