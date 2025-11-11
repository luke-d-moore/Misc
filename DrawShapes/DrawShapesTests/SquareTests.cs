using DrawShapes.Shape;

namespace DrawShapesTests
{
    public class SquareTests
    {
        [Fact]
        public void Constructor_ValidArguments_returnsTrue()
        {
            var square = new Square(15, 30, 35);
            Assert.True(square.Name == "Square");
            Assert.True(square.LocationX == 15);
            Assert.True(square.LocationY == 30);
            Assert.True(square.Width == 35);
            Assert.True(square.Text == string.Empty);
        }

        public static IEnumerable<object[]> InvalidArgumentData =>
        new List<object[]>
        {
            new object[] { -5 , 5, 300, "X location must not be less than 0."},
            new object[] { 5 , -5, 300, "Y location must not be less than 0."},
            new object[] { 5 , 5, -10, "Size must be greater than 0."},
            new object[] { 5 , 5, 0, "Size must be greater than 0."}
        };

        [Theory, MemberData(nameof(InvalidArgumentData))]
        public void Constructor_InValidArguments_ThrowsArgumentException(int x, int y, int size, string message)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Square(x, y, size));
            Assert.Equal(message, ex.Message);
        }
    }
}