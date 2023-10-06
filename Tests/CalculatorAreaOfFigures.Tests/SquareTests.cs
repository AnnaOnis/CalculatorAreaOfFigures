using FluentAssertions;

namespace CalculatorAreaOfFigures.Tests
{
    public class SquareTests
    {
        [Fact]
        public void Square_is_created()
        {
            //Arrange
            var square = new Square(5d);

            //Act / Assert
            square.SideA.Should().Be(5d);
            square.SideB.Should().Be(5d);
            square.SideC.Should().Be(5d);
            square.SideD.Should().Be(5d);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        [InlineData(double.MaxValue)]
        [InlineData(double.PositiveInfinity)]
        [InlineData(double.NegativeInfinity)]
        [InlineData(double.NaN)]
        public void Square_with_incorrect_side_will_not_be_created(double value)
        {
            //Act  /  Assert
            FluentActions.Invoking(() => new Square(value))
                .Should()
                .ThrowExactly<ArgumentOutOfRangeException>();
        }

    }
}
