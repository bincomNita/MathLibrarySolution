using Xunit;

namespace MathLibrary.Tests
{
    public class MathUtilsTests
    {
        [Fact]
        public void Square_ShouldReturnCorrectSquare()
        {           
            int number = 5;
            int expected = 25;
         
            int result = MathUtils.Square(number);
        
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Square_ShouldReturnZeroForZero()
        {
            Assert.Equal(0, MathUtils.Square(0));
        }
        [Fact]
        public void Square_ShouldReturnPositiveForNegativeInput()
        {
            Assert.Equal(9, MathUtils.Square(-3));
        }
    }
}
