using LawnMowers.App.MoveCommands;

namespace LawnMowers.App.MoveCommandProvider
{
    public interface IMoveCommandProvider
    {
        IMoveCommand GetCommand(Direction currentDirection);
    }
}