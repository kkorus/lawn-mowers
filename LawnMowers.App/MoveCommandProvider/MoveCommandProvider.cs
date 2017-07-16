using System;
using System.Collections.Generic;
using LawnMowers.App.MoveCommands;

namespace LawnMowers.App.MoveCommandProvider
{
    public class MoveCommandProvider : IMoveCommandProvider
    {
        private readonly Dictionary<Direction, Func<IMoveCommand>> _commands;

        public MoveCommandProvider()
        {
            _commands = new Dictionary<Direction, Func<IMoveCommand>>
            {
                {Direction.N, () => new MoveNorthCommand()},
                {Direction.W, () => new MoveLeftCommand()},
                {Direction.E, () => new MoveRightCommand()},
                {Direction.S, () => new MoveBottomCommand()}
            };
        }

        public IMoveCommand GetCommand(Direction currentDirection)
        {
            return _commands[currentDirection]();
        }
    }
}