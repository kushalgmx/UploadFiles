using Xunit;

namespace Test
{
    public class FreebieTest
    {
        [Fact]
        public void AddTwoNumbers()
        {
            // Arrange
            var oneDollar = 1.0M;
            var twoDollars = 2.0M;
            var threeDollars = 3.0M;
            var expected = threeDollars;


            // Act 
            var actual = oneDollar + twoDollars;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
