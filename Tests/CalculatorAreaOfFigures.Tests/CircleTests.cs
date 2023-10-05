using System.Net.WebSockets;

namespace CalculatorAreaOfFigures.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Area_of_circle_with_radius_5_is_valid()
        {
            var circle = new Ñircle(5);
            var valid = 78.54;

            var area = circle.CalculateArea();

            Assert.Equal(valid, area);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(0)]
        public void Creating_circle_with_an_invalid_radius_causes_exception(double p)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => {var circle = new Ñircle(p); });
        }
    }
}