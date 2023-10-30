namespace TestLibrary.LinkedListTests
{
    public class LinkedListTests
    {
        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 2 }, 2)]
        [InlineData(new[] { 3, 1, 2 }, 3)]
        public void SinglyLinkedList_ShouldAddToCount(int[] input, int expected)
        {
            // Arrange
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            foreach (int i in input)
            {
                singlyLinkedList.AddAtHead(i);
            }

            // Act
            int actual = singlyLinkedList.Count;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1 }, "1")]
        [InlineData(new[] { 1, 2 }, "21")]
        [InlineData(new[] { 3, 1, 2 }, "213")]
        public void SinglyLinkedList_ShouldAddAtHead(int[] input, string expected)
        {
            // Arrange
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            foreach (int i in input)
            {
                singlyLinkedList.AddAtHead(i);
            }

            // Act
            string actual = singlyLinkedList.ToString();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1 }, "1")]
        [InlineData(new[] { 1, 2 }, "12")]
        [InlineData(new[] { 3, 1, 2 }, "312")]
        public void SinglyLinkedList_ShouldAddAtTail(int[] input, string expected)
        {
            // Arrange
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            foreach (int i in input)
            {
                singlyLinkedList.AddAtTail(i);
            }

            // Act
            string actual = singlyLinkedList.ToString();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { }, 0, -1)]
        [InlineData(new[] { 1 }, 0, 1)]
        [InlineData(new[] { 1, 2 }, 1, 2)]
        [InlineData(new[] { 3, 1, 2 }, 2, 2)]
        [InlineData(new[] { 3, 1, 2 }, 4, -1)]
        [InlineData(new[] { 3, 1, 2 }, 3, -1)]
        public void SinglyLinkedList_ShouldGetValueAtIndexElseNegative1(int[] input, int index, int expected)
        {
            // Arrange
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            foreach (int i in input)
            {
                singlyLinkedList.AddAtTail(i);
            }

            // Act
            int actual = singlyLinkedList.Get(index);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { }, 1, 0, "1")]
        [InlineData(new int[] { }, 1, 1, "")]
        [InlineData(new[] { 1 }, 2, 0, "21")]
        [InlineData(new[] { 1, 2 }, 5, 2, "125")]
        [InlineData(new[] { 3, 1, 2 }, 2, 1, "3212")]
        [InlineData(new[] { 1, 2, 3, 4, 5, 7, 8 }, 6, 5, "12345678")]
        [InlineData(new[] { 1, 2, 3, 4, 5, 7, 8 }, 6, 22, "1234578")]
        [InlineData(new[] { 3, 1, 2 }, 3, 0, "3312")]
        public void SinglyLinkedList_ShouldAddAtIndexIfValid(int[] input, int toAdd, int index, string expected)
        {
            // Arrange
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            foreach (int i in input)
            {
                singlyLinkedList.AddAtTail(i);
            }

            // Act
            singlyLinkedList.AddAtIndex(index, toAdd);
            string actual = singlyLinkedList.ToString();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { },  0, "")]
        [InlineData(new int[] { },  1, "")]
        [InlineData(new[] { 1 },  0, "")]
        [InlineData(new[] { 1, 2 },  1, "1")]
        [InlineData(new[] { 3, 1, 2 },  1, "32")]
        [InlineData(new[] { 1, 2, 3, 4, 5, 7, 8 },  5, "123458")]
        [InlineData(new[] { 1, 2, 3, 4, 5, 7, 8 },  22, "1234578")]
        [InlineData(new[] { 3, 1, 2 }, 2, "31")]
        public void SinglyLinkedList_ShouldDeleteAtIndexIfValid(int[] input, int index, string expected)
        {
            // Arrange
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            foreach (int i in input)
            {
                singlyLinkedList.AddAtTail(i);
            }

            // Act
            singlyLinkedList.DeleteAtIndex(index);
            string actual = singlyLinkedList.ToString();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { }, 0, 0)]
        [InlineData(new int[] { }, 1, 0)]
        [InlineData(new[] { 1 }, 0, 0)]
        [InlineData(new[] { 1, 2 }, 1, 1)]
        [InlineData(new[] { 3, 1, 2 }, 1, 2)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 7, 8 }, 5, 6)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 7, 8 }, 22, 7)]
        [InlineData(new[] { 3, 1, 2 }, 2, 2)]
        public void SinglyLinkedList_ShouldDecrementCountIfValid(int[] input, int index, int expected)
        {
            // Arrange
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            foreach (int i in input)
            {
                singlyLinkedList.AddAtTail(i);
            }

            // Act
            singlyLinkedList.DeleteAtIndex(index);
            int actual = singlyLinkedList.Count;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
