using System;
using System.Collections.Generic;

namespace LawnMowers.App
{
    public class LawnMower : ILawnMower
    {
        private readonly Dictionary<char, Action> _instructionActions;

        private readonly IPosition _position;

        private string _instructions;

        public LawnMower(IPosition position, string instructions)
        {
            _position = position;
            _instructions = instructions;
            _instructionActions = new Dictionary<char, Action>
            {
                {'M', _position.Move},
                {'L', _position.TurnLeft},
                {'R', _position.TurnRight}
            };
        }

        public void StartMover()
        {
            _instructions = _instructions.ToUpper();
            foreach (var instruction in _instructions)
            {
                _instructionActions[instruction]();
            }
        }

        public void DisplayCurrentPosition()
        {
            Console.WriteLine(_position.CurrentPosition);
        }
    }
}