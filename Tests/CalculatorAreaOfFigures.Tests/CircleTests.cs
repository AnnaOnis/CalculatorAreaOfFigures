using FluentAssertions;

namespace CalculatorAreaOfFigures.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Area_of_circle_with_radius_5_is_valid()
        {
            //Arrange
            var circle = new Ñircle(5);
            var valid = 78.54;

            //Act / Assert
            Assert.Equal(valid, circle.Area);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(0)]
        [InlineData(double.MaxValue)]
        public void Circle_with_incorrect_radius_will_not_be_created(double radius)
        {
            //Act  /  Assert
            FluentActions.Invoking(() => new Ñircle(radius))
                .Should()
                .ThrowExactly<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Circle_and_triangle_have_common_parent()
        {
            //Arrange
            var circle = new Ñircle(5d);
            var triangle = new Triangle(5d, 6d, 7d);

            //Act  /  Assert
            circle.Should().BeAssignableTo<IFigure>();
            triangle.Should().BeAssignableTo<IFigure>();
        }
    }
}