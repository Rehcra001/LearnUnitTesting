namespace TestLibrary.SortingAlgorithmsTests
{
    public class SortingAlgorithmsTests
    {
        [Theory]
        [InlineData(new[] { 5, 8, 3, 9, 2, 1, 7 }, new[] { 1, 2, 3, 5, 7, 8, 9 })]
        public void MergeSort_ShouldOrderAnArrayOfTypeInteger(int[] actual, int[] expected)
        {
            // Arrange

            // Act
            Sort<int>.MergeSort(actual, 0, actual.Length - 1);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { '5', '8', '3', '9', '2', '1', '7' }, new[] { '1', '2', '3', '5', '7', '8', '9' })]
        public void MergeSort_ShouldOrderAnArrayOfTypeChar(char[] actual, char[] expected)
        {
            // Arrange

            // Act
            Sort<char>.MergeSort(actual, 0, actual.Length - 1);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 5, 8, 3, 9, 2, 1, 7 }, new[] { 1, 2, 3, 5, 7, 8, 9 })]
        public void QuickSort_ShouldOrderAnArrayOfTypeInteger(int[] actual, int[] expected)
        {
            // Arrange

            // Act
            Sort<int>.QuickSort(actual, 0, actual.Length - 1);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { '5', '8', '3', '9', '2', '1', '7' }, new[] { '1', '2', '3', '5', '7', '8', '9' })]
        public void QuickSort_ShouldOrderAnArrayOfTypeChar(char[] actual, char[] expected)
        {
            // Arrange

            // Act
            Sort<char>.QuickSort(actual, 0, actual.Length - 1);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
