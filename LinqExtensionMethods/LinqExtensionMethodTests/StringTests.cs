using LinqExtensionMethods.LinqExtensionClasses;

namespace LinqExtensionMethodTests
{
    public class StringTests
    {
        [Fact]
        public void Capitalise_RetrunsTrue()
        {
            string name = "luke";

            Assert.True(name.Capitalise()=="Luke");
        }
        [Fact]
        public void Capitalise_ThrowsException()
        {
            string name = string.Empty;

            name = null;

            Assert.Throws<InvalidOperationException>(() => name.Capitalise());
        }
    }
}