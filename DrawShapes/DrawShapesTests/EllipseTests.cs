using DrawShapes.Shape;

namespace DrawShapesTests
{
    public class EllipseTests
    {
        [Fact]
        public void Constructor_ValidArguments_returnsTrue()
        {
            var ellpse = new Ellipse(15, 30, 30, 40);
            Assert.True(ellpse.Name == "Ellipse");
            Assert.True(ellpse.LocationX == 15);
            Assert.True(ellpse.LocationY == 30);
            Assert.True(ellpse.Width == 30);
            Assert.True(ellpse.Height == 40);
            Assert.True(ellpse.Text == string.Empty);
        }

        public static IEnumerable<object[]> InvalidArgumentData =>
        new List<object[]>
        {
            new object[] { -5 , 5, 30, 40, "X location must not be less than 0."},
            new object[] { 5 , -5, 30, 40, "Y location must not be less than 0."},
            new object[] { 5 , 5, -10, 40, "Width must be greater than 0."},
            new object[] { 5 , 5, 0, 40, "Width must be greater than 0."},
            new object[] { 5 , 5, 30, -40, "Height must be greater than 0."},
            new object[] { 5 , 5, 30, 0, "Height must be greater than 0."}
        };

        [Theory, MemberData(nameof(InvalidArgumentData))]
        public void Constructor_InValidArguments_ThrowsArgumentException(int x, int y, int width, int height, string message)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Ellipse(x, y, width, height));
            Assert.Equal(message, ex.Message);
        }
    }
}
