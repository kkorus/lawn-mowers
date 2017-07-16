namespace LawnMowers.App
{
    public interface IPosition
    {
        string CurrentPosition { get; }
        void Move();
        void TurnLeft();
        void TurnRight();
    }
}