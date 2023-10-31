using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.LinkedListTests
{
    public class TwoPointerTechniqueTests
    {
        [Theory]
        [InlineData(10, -1, false)]
        [InlineData(10, 0, true)]
        [InlineData(0, -1, false)]
        [InlineData(0, 0, false)]
        [InlineData(1, -1, false)]
        [InlineData(1, 0, true)]
        public void HasCycle_ShouldReturnTrueIfCycleFalseOtherwise(int len, int cycleIndex, bool expected)
        {
            // Arrange
            ListNode? head = TwoPointerTechnique.CreateCycle(len, cycleIndex);
            // Act
            bool actual = TwoPointerTechnique.HasCycle(head!);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
