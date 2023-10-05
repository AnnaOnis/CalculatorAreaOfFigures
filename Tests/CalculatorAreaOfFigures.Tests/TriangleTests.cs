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
            var triangle = new Triangle(6, 8, 10);
            var valid = 24;

            var area = triangle.CalculateArea();

            Assert.Equal(area, valid);
        }

        [Fact]
        public void Tringle_with_side_6_8_10_is_rectangular()
        {
            var triangle = new Triangle(6, 8, 10);

            var area = triangle.IsRectangular();

            Assert.True(area);
        }

        [Fact]
        public void Triangle_with_side_2_3_6_causes_exception()
        {
            Assert.Throws<InvalidOperationException>(() => { var triangle = new Triangle(2, 3, 6); });
        }

        [Theory]
        [InlineData(0, 3, 4)]
        [InlineData(2, 0, 3)]
        [InlineData(2, 3, 0)]
        [InlineData(-2, 3, 4)]
        [InlineData(2, -3, 4)]
        [InlineData(2, 3, -4)]
        public void Triangle_with_an_invalid_side_causes_exception(double a, double b, double c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { var triangle = new Triangle(a, b, c); });
        }

    }
}
