using System;
using System.Text.RegularExpressions;

namespace LawnMowers.App.Infrastructure
{
    public class InputParser : IInputParser
    {
        public const string SizePattern = @"(\d+) (\d+)";

        public const string CoordinatesPattern = @"(\d+) (\d+) ([NSEW]?)";

        public const string InstructionsPattern = @"([LRM]*)";

        public InputData ParseInput()
        {
            var inputData = new InputData();

            ParseSizeLine(ref inputData);
            ParseMoversData(ref inputData);

            return inputData;
        }

        private void ParseSizeLine(ref InputData inputData)
        {
            var sizeLine = Console.ReadLine();
            var match = Regex.Match(sizeLine, SizePattern);
            inputData.LawnWidth = int.Parse(match.Groups[1].Value);
            inputData.LawnHeight = int.Parse(match.Groups[2].Value);
        }

        private void ParseMoversData(ref InputData inputData)
        {
            var isLawnPositionLine = true;
            var moverData = new MoverData();

            string line;
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                if (isLawnPositionLine)
                {
                    ParseLawnPositionLine(line, ref moverData);
                    isLawnPositionLine = false;
                }
                else
                {
                    ParseInstructionsLine(line, ref moverData);
                    inputData.MowerData.Add(moverData);
                    moverData = new MoverData();
                    isLawnPositionLine = true;
                }
            }
        }

        private void ParseLawnPositionLine(string positionLine, ref MoverData moverData)
        {
            var match = Regex.Match(positionLine, CoordinatesPattern);
            var x = int.Parse(match.Groups[1].Value);
            var y = int.Parse(match.Groups[2].Value);
            var direction = (Direction) Enum.Parse(typeof (Direction), match.Groups[3].Value);

            moverData.StartCoordinates = new Coordinates(x, y, direction);
        }

        private void ParseInstructionsLine(string instructionLine, ref MoverData moverData)
        {
            var match = Regex.Match(instructionLine, InstructionsPattern);
            moverData.Instructions = match.Groups[1].Value;
        }
    }
}