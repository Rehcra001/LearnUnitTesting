namespace TestLibrary.ArraysAndStringsTests
{
    public class MultiDimensionalArraysTest
    {
        [Theory]
        [InlineData(3, 3, new int[] { 0, 1, 0, 0, 1, 2, 2, 1, 2 })]
        [InlineData(3, 4, new int[] { 0, 1, 0, 0, 1, 2, 3, 2, 1, 2, 3, 3 })]
        [InlineData(4, 3, new int[] { 0, 1, 0, 0, 1, 2, 2, 1, 0, 1, 2, 2 })]
        [InlineData(1, 1, new int[] { 0 })]
        [InlineData(1, 2, new int[] { 0, 1 })]
        [InlineData(2, 1, new int[] { 0, 0 })]
        public void FindDiagonalOrder_ShouldReturnTheDiagonalOrder(int m, int n, int[] expected)
        {
            // Arrange


            // Act
            int[][] mat = GenerateSimpleMatrix(m, n);
            int[] actual = MultiDimensionalArrays.FindDiagonalOrder(mat);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 3, new int[] { 0, 1, 2, 2, 2, 1, 0, 0, 1 })]
        [InlineData(3, 4, new int[] { 0, 1, 2, 3, 3, 3, 2, 1, 0, 0, 1, 2 })]
        [InlineData(4, 3, new int[] { 0, 1, 2, 2, 2, 2, 1, 0, 0, 0, 1, 1 })]
        [InlineData(4, 4, new int[] { 0, 1, 2, 3, 3, 3, 3, 2, 1, 0, 0, 0, 1, 2, 2, 1 })]
        [InlineData(1, 1, new int[] { 0 })]
        [InlineData(1, 2, new int[] { 0, 1 })]
        [InlineData(2, 1, new int[] { 0, 0 })]
        public void SpiralOrder_ShouldReturnTheSpiralOrder(int m, int n, int[] expected)
        {
            // Arrange

            // Act
            int[][] mat = GenerateSimpleMatrix(m, n);
            IList<int> actual = MultiDimensionalArrays.SpiralOrder(mat);

            // Assert
            Assert.Equal(expected.ToList(), actual.ToList());
        }

        [Theory]
        [InlineData(1, new[] { 1 })]
        [InlineData(2, new[] { 1 }, new[] { 1, 1 })]
        [InlineData(3, new[] { 1 }, new[] { 1, 1 }, new[] { 1, 2, 1 })]
        [InlineData(4, new[] { 1 }, new[] { 1, 1 }, new[] { 1, 2, 1 }, new[] { 1, 3, 3, 1 })]
        [InlineData(5, new[] { 1 }, new[] { 1, 1 }, new[] { 1, 2, 1 }, new[] { 1, 3, 3, 1 }, new[] { 1, 4, 6, 4, 1 })]
        [InlineData(6, new[] { 1 }, new[] { 1, 1 }, new[] { 1, 2, 1 }, new[] { 1, 3, 3, 1 }, new[] { 1, 4, 6, 4, 1 }, new[] { 1, 5, 10, 10, 5, 1 })]
        public void Generate_ShouldGenerateAndReturnNRowsofPascalsTriangle(int numRows, params int[][] expected)
        {
            // Arrange

            //Act
            IList<IList<int>> actual = MultiDimensionalArrays.Generate(numRows);

            //Assert
            Assert.Equal(expected, actual);
        }

        private static int[][] GenerateSimpleMatrix(int m, int n)
        {
            int[][] mat = new int[m][];
            for (int i = 0; i < m; i++)
            {
                mat[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    mat[i][j] = j;
                }
            }
            return mat;
        }

    }
}
