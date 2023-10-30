using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.ArraysAndStringsTests
{
    public class ArraysTest
    {
        [Theory]
        [InlineData(new[] { 1, 4, 3, 2 }, 4)]
        [InlineData(new[] { -10, -236, 65, -5, 6, 99, 88, -151, 4, 3, 2, 3 }, -147)]
        [InlineData(new[] { -10, -236 }, -236)]
        [InlineData(new[] { 99, 88 }, 88)]
        [InlineData(new[] { 6, 5, 4, 3, 2, 1 }, 9)]
        public void ArrayPairSum_ShouldReturnTheMaxSumOfMinPairs(int[] arr, int expected)
        {
            // Arrange

            // Act
            int actual = Arrays.ArrayPairSum(arr);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 16 }, 21, new[] { 5, 6 })]
        [InlineData(new[] { 1, 2, 4, 5, 16 }, 3, new[] { 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4, 16, 21, 22, 33 }, 20, new[] { 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 16, 18, 22, 33, 35, 56, 99 }, 100, new[] { 1, 12 })]
        [InlineData(new[] { 12, 13, 23, 28, 43, 44, 59, 60, 61, 68, 70, 86, 88, 92, 124, 125, 136, 168, 173, 173, 180, 199, 212, 221, 227, 230, 277, 282, 306, 314, 316, 321, 325, 328, 336, 337, 363, 365, 368, 370, 370, 371, 375, 384, 387, 394, 400, 404, 414, 422, 422, 427, 430, 435, 457, 493, 506, 527, 531, 538, 541, 546, 568, 583, 585, 587, 650, 652, 677, 691, 730, 737, 740, 751, 755, 764, 778, 783, 785, 789, 794, 803, 809, 815, 847, 858, 863, 863, 874, 887, 896, 916, 920, 926, 927, 930, 933, 957, 981, 997 }, 542, new[] { 24, 32 })]
        public void TwoSum_ShouldReturnArrayOfOneBasedArrayOfIndicesThatSumToTarget(int[] numbers, int target, int[] expected)
        {
            // Arrange

            // Act
            int[] actual = Arrays.TwoSum(numbers, target);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        [InlineData(new[] { 3, 3, 3, 3 }, 3, 0)]
        [InlineData(new[] { 3, 2, 2, 2 }, 3, 3)]
        [InlineData(new[] { 3, 3, 2, 3 }, 3, 1)]
        [InlineData(new int[] { }, 3, 0)]
        [InlineData(new[] { 3, 3, 3, 3 }, 2, 4)]
        [InlineData(new[] { 2 }, 3, 1)]
        [InlineData(new[] { 4, 5 }, 4, 1)]

        public void RemoveElement_ShouldReturnNumberOfNonValElements(int[] nums, int val, int expected)
        {
            // Arrange

            // Act
            int actual = Arrays.RemoveElement(nums, val);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        [InlineData(new[] { 3, 3, 3, 3 }, 3, 0)]
        [InlineData(new[] { 3, 2, 2, 2 }, 3, 3)]
        [InlineData(new[] { 3, 3, 2, 3 }, 3, 1)]
        [InlineData(new int[] { }, 3, 0)]
        [InlineData(new[] { 3, 3, 3, 3 }, 2, 4)]
        [InlineData(new[] { 2 }, 3, 1)]
        [InlineData(new[] { 4, 5 }, 4, 1)]

        public void RemoveElement2_ShouldReturnNumberOfNonValElements(int[] nums, int val, int expected)
        {
            // Arrange

            // Act
            int actual = Arrays.RemoveElement2(nums, val);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 0 }, 0)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 0, 0 }, 0)]
        [InlineData(new[] { 1, 0 }, 1)]
        [InlineData(new[] { 0, 1 }, 1)]
        [InlineData(new[] { 0, 0, 0 }, 0)]
        [InlineData(new[] { 0, 1, 0 }, 1)]
        [InlineData(new[] { 0, 1, 1 }, 2)]
        [InlineData(new[] { 1, 1, 1 }, 3)]
        [InlineData(new[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }, 3)]
        [InlineData(new[] { 0, 1, 1, 0, 0, 1, 1, 0, 0 }, 2)]
        public void FindMaxConsecutiveOnes_ShouldReturnMaxNumberOfConsecutiveOnes(int[] nums, int expected)
        {
            // Arrange

            // Act
            int actual = Arrays.FindMaxConsecutiveOnes(nums);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3 }, 1, new[] { 3, 1, 2 })]
        [InlineData(new[] { 1 }, 1, new[] { 1 })]
        [InlineData(new[] { -1, -100, 3, 99 }, 2, new[] { 3, 99, -1, -100 })]
        [InlineData(new[] { -1, -100, 3, 99 }, 6, new[] { 3, 99, -1, -100 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 5, 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 4, 5, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 3, 4, 5, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 2, 3, 4, 5, 1 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 6, new[] { 5, 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 7, new[] { 4, 5, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 1, new[] { 4, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 2, new[] { 3, 4, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 3, new[] { 2, 3, 4, 1 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 5, new[] { 4, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 6, new[] { 3, 4, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 7, new[] { 2, 3, 4, 1 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 4, new[] { 3, 4, 5, 6, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 3, new[] { 4, 5, 6, 1, 2, 3 })]
        public void Rotate_ShouldRotateTheArrayByKSteps(int[] actual, int k, int[] expected)
        {
            // Arrange

            // Act
            Arrays.Rotate(actual, k);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3 }, 1, new[] { 3, 1, 2 })]
        [InlineData(new[] { 1 }, 1, new[] { 1 })]
        [InlineData(new[] { -1, -100, 3, 99 }, 2, new[] { 3, 99, -1, -100 })]
        [InlineData(new[] { -1, -100, 3, 99 }, 6, new[] { 3, 99, -1, -100 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 5, 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 4, 5, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 3, 4, 5, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 2, 3, 4, 5, 1 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 6, new[] { 5, 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 7, new[] { 4, 5, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 1, new[] { 4, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 2, new[] { 3, 4, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 3, new[] { 2, 3, 4, 1 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 5, new[] { 4, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 6, new[] { 3, 4, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 7, new[] { 2, 3, 4, 1 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 4, new[] { 3, 4, 5, 6, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 3, new[] { 4, 5, 6, 1, 2, 3 })]
        public void Rotate2_ShouldRotateTheArrayByKSteps(int[] actual, int k, int[] expected)
        {
            // Arrange

            // Act
            Arrays.Rotate2(actual, k);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3 }, 1, new[] { 3, 1, 2 })]
        [InlineData(new[] { 1 }, 1, new[] { 1 })]
        [InlineData(new[] { -1, -100, 3, 99 }, 2, new[] { 3, 99, -1, -100 })]
        [InlineData(new[] { -1, -100, 3, 99 }, 6, new[] { 3, 99, -1, -100 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 5, 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 4, 5, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 3, 4, 5, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 2, 3, 4, 5, 1 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 6, new[] { 5, 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 7, new[] { 4, 5, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 1, new[] { 4, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 2, new[] { 3, 4, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 3, new[] { 2, 3, 4, 1 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 5, new[] { 4, 1, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 6, new[] { 3, 4, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 7, new[] { 2, 3, 4, 1 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 4, new[] { 3, 4, 5, 6, 1, 2 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 3, new[] { 4, 5, 6, 1, 2, 3 })]
        public void Rotate3_ShouldRotateTheArrayByKSteps(int[] actual, int k, int[] expected)
        {
            // Arrange

            // Act
            Arrays.Rotate3(actual, k);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2 }, 2)]
        [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        [InlineData(new[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new[] { 0 }, 1)]
        [InlineData(new[] { 0, 0 }, 1)]
        [InlineData(new[] { 0, 1 }, 2)]
        [InlineData(new[] { 0, 0, 1, 1 }, 2)]
        [InlineData(new[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 2)]
        public void RemoveDuplicates_ShouldReturnTheNumberOfUniqueIntegersInOrderUptoExpected(int[] nums, int expected)
        {
            // Arrange

            // Act
            int actual = Arrays.RemoveDuplicates(nums);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 0 }, 0)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 0, 1 }, 1)]
        [InlineData(new[] { 0, 1, 1 }, 2)]
        [InlineData(new[] { 0, 1, 1, 0 }, 2)]
        [InlineData(new[] { 0, 1, 0, 1, 0 }, 2)]
        [InlineData(new[] { 1, 1, 1, 1 }, 4)]
        [InlineData(new[] { 0, 0, 0, 0 }, 0)]
        [InlineData(new[] { 1, 0, 1, 0 }, 2)]
        [InlineData(new[] { 1, 0, 1, 0, 1 }, 3)]
        [InlineData(new[] { 1, 1, 0, 0, 0, 0, 0, 0, 0 }, 2)]
        [InlineData(new[] { 1, 0, 0, 1, 0, 0, 0, 0, 0 }, 2)]
        public void MoveZero_ShouldMoveZeroesToTheBackAndReturnNumberOfNonZeroes(int[] nums, int expected)
        {
            // Arrange

            // Act
            int actual = Arrays.MoveZero(nums);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 0 }, 0)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 0, 1 }, 1)]
        [InlineData(new[] { 0, 1, 1 }, 2)]
        [InlineData(new[] { 0, 1, 1, 0 }, 2)]
        [InlineData(new[] { 0, 1, 0, 1, 0 }, 2)]
        [InlineData(new[] { 1, 1, 1, 1 }, 4)]
        [InlineData(new[] { 0, 0, 0, 0 }, 0)]
        [InlineData(new[] { 1, 0, 1, 0 }, 2)]
        [InlineData(new[] { 1, 0, 1, 0, 1 }, 3)]
        [InlineData(new[] { 1, 1, 0, 0, 0, 0, 0, 0, 0 }, 2)]
        [InlineData(new[] { 1, 0, 0, 1, 0, 0, 0, 0, 0 }, 2)]
        public void MoveZero2_ShouldMoveZeroesToTheBackAndReturnNumberOfNonZeroes(int[] nums, int expected)
        {
            // Arrange

            // Act
            int actual = Arrays.MoveZero2(nums);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
