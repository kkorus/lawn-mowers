namespace LawnMowers.App.MoveCommands
{
    public interface IMoveCommand
    {
        ICoordinates GetNextCoordinates(ICoordinates coordinates);
    }
}