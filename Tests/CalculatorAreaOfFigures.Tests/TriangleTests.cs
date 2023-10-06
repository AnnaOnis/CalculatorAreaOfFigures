using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAreaOfFigures.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Area_of_tringle_with_side_6_8_10_is_valid()
        {
            //Arrange
            var triangle = new Triangle(6, 8, 10);
            var valid = 24;

            //Act
            var area = triangle.CalculateArea();

            //Assert
            Assert.Equal(area, valid);
        }

        [Fact]
        public void Tringle_with_side_6_8_10_is_rectangular()
        {
            //Arrange
            var triangle = new Triangle(6, 8, 10);

            //Act
            var area = triangle.IsRectangular();

            //Assert
            Assert.True(area);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(2, 9, 5)]
        [InlineData(1, 3, 6)]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue)]
        public void Triangle_with_incorrect_side_will_not_be_created(double a, double b, double c)
        {
            //Act  /  Assert
            FluentActions.Invoking(() => new Triangle(a, b, c))
                .Should()
                .Throw<ArgumentException>();

            //Assert.Throws<ArgumentException>(() => { var triangle = new Triangle(a, b, c); });
        }

        [Theory]
        [InlineData(0, 3, 4)]
        [InlineData(2, 0, 3)]
        [InlineData(2, 3, 0)]
        [InlineData(-2, 3, 4)]
        [InlineData(2, -3, 4)]
        [InlineData(2, 3, -4)]
        [InlineData(double.NaN, 3, 4)]
        [InlineData(2, double.NaN, 4)]
        [InlineData(2, 3, double.NaN)]
        [InlineData(double.NegativeInfinity, 3, 4)]
        [InlineData(2, double.NegativeInfinity, 4)]
        [InlineData(2, 3, double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity, 3, 4)]
        [InlineData(2, double.PositiveInfinity, 4)]
        [InlineData(2, 3, double.PositiveInfinity)]
        public void Triangle_with_negative_or_zero_sides_will_not_be_created(double a, double b, double c)
        {
            //Act  /  Assert
            FluentActions.Invoking(() => new Triangle(a, b, c))
                .Should()
                .ThrowExactly<ArgumentOutOfRangeException>();

            //Assert.Throws<ArgumentOutOfRangeException>(() => { var triangle = new Triangle(a, b, c); });
        }



    }
}
