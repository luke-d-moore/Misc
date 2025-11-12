using LinqExtensionMethods.LinqExtensionClasses;

namespace LinqExtensionMethodTests
{
    public class GenericTests
    {
        public static IEnumerable<object[]> IncludesDataTrue =>
            new List<object[]>
            {
                new object[] { new List<string>() { "abc", "def", "ghi" } , new List<string>() { "shfgh", "hsfhfhs", "abc", "def", "ghi" }},
                new object[] { new List<int>() { 1, 3, 6 }, new List<int>() { 1, 4, 8, 3, 6 } }
            };

        [Theory, MemberData(nameof(IncludesDataTrue))]
        public void Includes_ReturnsTrue<T>(List<T> list1, List<T> list2)
        {
            Assert.True(list2.Includes(list1));
        }

        public static IEnumerable<object[]> IncludesDataFalse =>
            new List<object[]>
            {
                new object[] { new List<string>() { "abcd", "def", "ghi" } , new List<string>() { "shfgh", "hsfhfhs", "abc", "def", "ghi" }},
                new object[] { new List<int>() { 1, 5, 6 }, new List<int>() { 1, 4, 8, 3, 6 } }
            };

        [Theory, MemberData(nameof(IncludesDataFalse))]
        public void Includes_ReturnsFalse<T>(List<T> list1, List<T> list2)
        {
            Assert.False(list2.Includes(list1));
        }

        public static IEnumerable<object[]> IncludesDataThrowsException =>
            new List<object[]>
            {
                new object[] { new List<string>() { "abcd", "def", "ghi" } , new List<string>() { "shfgh", "hsfhfhs", "abc", "def", "ghi" }},
                new object[] { new List<int>() { 1, 5, 6 }, new List<int>() { 1, 4, 8, 3, 6 } }
            };

        [Theory, MemberData(nameof(IncludesDataThrowsException))]
        public void Includes_NullSourceEnumerable_ThrowsException<T>(List<T> list1, List<T> list2)
        {
            list2 = null;

            Assert.Throws<InvalidOperationException>(()=>list2.Includes(list1));
        }

        [Theory, MemberData(nameof(IncludesDataThrowsException))]
        public void Includes_NullCompareEnumerable_ThrowsException<T>(List<T> list1, List<T> list2)
        {
            list1 = null;

            Assert.Throws<InvalidOperationException>(() => list2.Includes(list1));
        }
    }
}