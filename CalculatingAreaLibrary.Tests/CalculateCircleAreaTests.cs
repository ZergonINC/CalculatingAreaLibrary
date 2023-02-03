using CalculatingAreaLibrary.Shapes;

namespace CalculatingAreaLibrary.Tests
{
    public class CalculateCircleAreaTests
    {
        [Fact]
        public void Area_SimpleValue_ShouldBeCalculated()
        {
            //arrange
            double expected = 113.097;

            //act
            Circle circle = new(6);
            double result = circle.CalculateArea();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Area_BigValue_ShouldBeCalculated()
        {
            //arrange
            double expected = 229282382.256;

            //act
            Circle circle = new(8543);
            double result = circle.CalculateArea();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Area_DoubleValue_ShouldBeCalculated()
        {
            //arrange
            double expected = 2042.821;

            //act
            Circle circle = new(25.5);
            double result = circle.CalculateArea();

            //assert
            Assert.Equal(expected, result);
        }
    }
}