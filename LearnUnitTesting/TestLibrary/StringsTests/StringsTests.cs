namespace TestLibrary.StringsTests
{
    public class StringsTests
    {
        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        [InlineData("1010", "11", "1101")]
        public void AddBinary_ShouldReturnTheSumOfTwoBinaryStrings(string a, string b, string expected)
        {
            // Arrange

            // Act
            string actual = Strings.AddBinary(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        [InlineData("1010", "11", "1101")]
        public void AddBinary2_ShouldReturnTheSumOfTwoBinaryStrings(string a, string b, string expected)
        {
            // Arrange

            // Act
            string actual = Strings.AddBinary2(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcd", "a", 0)]
        [InlineData("abcd", "b", 1)]
        [InlineData("abcd", "e", -1)]
        [InlineData("abcd", "cd", 2)]
        [InlineData("abcd", "d", 3)]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("thetruthaboutcodingsinthebigwideworld", "sad", -1)]
        [InlineData("thetruthaboutcodinginthebigwideworld", "coding", 13)]
        [InlineData("thetruthaboutcodinginthebigwideworld", "world", 31)]
        [InlineData("thetruthaboutcodinginthebigwideworl", "world", -1)]
        public void StrStr_ShouldReturnIndexOfFirstMatchingSubstringOrNegativeOneOtherWise(string str, string subStr, int expected)
        {
            // Arrange

            // Act
            int actual = Strings.StrStr(str, subStr);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { "flow", "flow" }, "flow")]
        [InlineData(new[] { "flower", "flow", "flows" }, "flow")]
        [InlineData(new[] { "flower" }, "flower")]
        [InlineData(new[] { "flower", "flow", "flows", "flounder" }, "flo")]
        [InlineData(new[] { "flower", "flow", "flows", "stop" }, "")]
        public void LongestCommonPrefix_ShouldReturTheLongestCommonPrefixOrAnEmptyString(string[] strs, string expected)
        {
            // Arrange

            // Act
            string actual = Strings.LongestCommonPrefix(strs);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 'a' }, new[] { 'a' })]
        [InlineData(new[] { 'a', 'b', 'c' }, new[] { 'c', 'b', 'a' })]
        [InlineData(new[] { 'a', 'b', 'c', 'd' }, new[] { 'd', 'c', 'b', 'a' })]
        public void ReverseString_ShouldReverseTheString(char[] actual, char[] expected)
        {
            // Arrange

            // Act
            Strings.ReverseString(actual);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("  hello world  ", "world hello")]
        [InlineData("a good   example", "example good a")]
        [InlineData("asdasd df f", "f df asdasd")]
        public void ReverseWords_ReversesTheWordsInAStringAndStripsAdditionalSpaces(string s, string expected)
        {
            // Arrange

            // Act
            string actual = Strings.ReverseWords(s);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
