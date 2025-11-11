using DrawShapes.Shape;

namespace DrawShapesTests
{
    public class TextBoxTests
    {
        [Fact]
        public void Constructor_ValidArguments_returnsTrue()
        {
            var textBox = new TextBox(15, 30, 30, 40, "");
            Assert.True(textBox.Name == "TextBox");
            Assert.True(textBox.LocationX == 15);
            Assert.True(textBox.LocationY == 30);
            Assert.True(textBox.Width == 30);
            Assert.True(textBox.Height == 40);
            Assert.True(textBox.Text == string.Empty);
        }

        public static IEnumerable<object[]> InvalidArgumentData =>
        new List<object[]>
        {
            new object[] { -5 , 5, 30, 40, "abc", "X location must not be less than 0."},
            new object[] { 5 , -5, 30, 40, "abc", "Y location must not be less than 0."},
            new object[] { 5 , 5, -10, 40, "abc", "Width must be greater than 0."},
            new object[] { 5 , 5, 0, 40, "abc", "Width must be greater than 0."},
            new object[] { 5 , 5, 30, -40, "abc", "Height must be greater than 0."},
            new object[] { 5 , 5, 30, 0, "abc", "Height must be greater than 0."},
            new object[] { 5 , 5, 30, 40, null, "Text must not be null." }
        };

        [Theory, MemberData(nameof(InvalidArgumentData))]
        public void Constructor_InValidArguments_ThrowsArgumentException(int x, int y, int width, int height, string text, string message)
        {
            var ex = Assert.Throws<ArgumentException>(() => new TextBox(x, y, width, height, text));
            Assert.Equal(message, ex.Message);
        }
    }
}
