using LinqExtensionMethods.LinqExtensionClasses;

namespace LinqExtensionMethodTests
{
    public class NumberTests
    {
        [Fact]
        public void PercentageDouble_ReturnsTrue()
        {
            double number = 5.0;

            Assert.True(number.Percentage(100) == 5.0);
        }
        [Fact]
        public void PercentageDouble_ReturnsFalse()
        {
            double number = 5.0;

            Assert.False(number.Percentage(90) == 5.0);
        }
        [Fact]
        public void PercentageDouble_ThrowsException()
        {
            double number = 5.0;

            Assert.Throws<InvalidOperationException>(() => number.Percentage(0));
        }
        [Fact]
        public void PercentageDecimal_ReturnsTrue()
        {
            decimal number = 5.0m;

            Assert.True(number.Percentage(100) == 5.0m);
        }
        [Fact]
        public void PercentageDecimal_ReturnsFalse()
        {
            decimal number = 5.0m;

            Assert.False(number.Percentage(90) == 5.0m);
        }
        [Fact]
        public void PercentageDecimal_ThrowsException()
        {
            decimal number = 5.0m;

            Assert.Throws<InvalidOperationException>(() => number.Percentage(0));
        }
    }
}