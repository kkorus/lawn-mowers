namespace LawnMowers.App
{
    public interface ICoordinates
    {
        int X { get; set; }

        int Y { get; set; }

        Direction Direction { get; set; }
    }
}