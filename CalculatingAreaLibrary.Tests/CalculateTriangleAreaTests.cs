using CalculatingAreaLibrary.Shapes;

namespace CalculatingAreaLibrary.Tests
{
    public class CalculateTriangleAreaTests
    {
        [Fact]
        public void Area_SimpleValue_ShouldBeCalculated()
        {
            //arrange
            double expected = 11.619;

            //act
            Triangle triangle = new(6, 4, 8);
            double result = triangle.CalculateArea();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Area_BigValue_ShouldBeCalculated()
        {
            //arrange
            double expected = 467170.939;

            //act
            Triangle triangle = new(1578, 1245, 764);
            double result = triangle.CalculateArea();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Area_DoubleValue_ShouldBeCalculated()
        {
            //arrange
            double expected = 16.327;

            //act
            Triangle triangle = new(6.7, 4.9, 8.7);
            double result = triangle.CalculateArea();

            //assert
            Assert.Equal(expected, result);
        }
    }
}
