using CalculatingAreaLibrary.Shapes;

namespace CalculatingAreaLibrary.Tests
{
    public class CalculateRectangleAreaTests
    {
        [Fact]
        public void Area_SimpleValue_ShouldBeCalculated()
        {
            //arrange
            double expected = 35;

            //act
            Rectangle rectangle = new(7, 5);
            double result = rectangle.CalculateArea();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Area_BigValue_ShouldBeCalculated()
        {
            //arrange
            double expected = 9283596;

            //act
            Rectangle rectangle = new(4326, 2146);
            double result = rectangle.CalculateArea();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Area_DoubleValue_ShouldBeCalculated()
        {
            //arrange
            double expected = 9528.915;

            //act
            Rectangle rectangle = new(74.96, 127.12);
            double result = rectangle.CalculateArea();

            //assert
            Assert.Equal(expected, result);
        }
    }
}
