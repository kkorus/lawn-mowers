using System;
using System.Collections.Generic;
using System.IO;
using LawnMowers.App;
using Xunit;

namespace LawnMowers.Tests
{
    public class MowerTests
    {
        public static IEnumerable<object[]> StartMowerTestCases => new[]
        {
            new object[] {new Position(new Lawn(5, 5), new Coordinates(1, 2, Direction.N)), "LMLMLMLMM", "1 3 N\r\n"},
            new object[] {new Position(new Lawn(5, 5), new Coordinates(3, 3, Direction.E)), "MMRMMRMRRM", "5 1 E\r\n"},
            new object[] {new Position(new Lawn(5, 5), new Coordinates(0, 0, Direction.N)), "RMMMMM", "5 0 E\r\n"},
            new object[] {new Position(new Lawn(5, 5), new Coordinates(5, 5, Direction.S)), "MMMMMRMMMMM", "0 0 W\r\n"},
        };

        [Theory, MemberData(nameof(StartMowerTestCases))]
        public void StartMower__StartPositionAndInstructionsParameters_MowesMowerToLocation(IPosition startPosition, string instructions, string expectedEndPosition)
        {
            // Arrange
            ILawnMower mower = new LawnMower(startPosition, instructions);

            // Act
            mower.StartMover();

            // Assert
            using (var consoleText = new StringWriter())
            {
                Console.SetOut(consoleText);
                mower.DisplayCurrentPosition();
                Assert.Equal(consoleText.ToString(), expectedEndPosition);
            }
        }
    }
}