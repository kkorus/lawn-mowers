using System.Collections.Generic;
using LawnMowers.App;
using Xunit;

namespace LawnMowers.Tests
{
    public class LawnTests
    {
        public static IEnumerable<object[]> AreCoordinatesValidTestCases => new[]
        {
            new object[] {new Coordinates(-1, -1, Direction.N), false},
            new object[] {new Coordinates(6, 6, Direction.N), false},
            new object[] {new Coordinates(6, 5, Direction.N), false},
            new object[] {new Coordinates(5, 6, Direction.N), false},
            new object[] {new Coordinates(0, 0, Direction.N), true},
            new object[] {new Coordinates(1, 1, Direction.N), true},
            new object[] {new Coordinates(5, 5, Direction.N), true}
        };

        [Theory, MemberData(nameof(AreCoordinatesValidTestCases))]
        public void AreCoordinatesValid_CoordinatesParameter_ReturnsResult(ICoordinates coordinates, bool expectedResult)
        {
            // Arrange
            ILawn lawn = new Lawn(5, 5);

            // Act
            var result = lawn.AreCoordinatesValid(coordinates);

            // Assert 
            Assert.Equal(expectedResult, result);
        }
    }
}