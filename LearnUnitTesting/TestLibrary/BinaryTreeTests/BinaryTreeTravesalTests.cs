using LeetCodeSolutionsLibrary.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.BinaryTreeTests
{
    public class BinaryTreeTravesalTests
    {
        [Fact]
        public void PreorderTraversal_ShouldReturnEmptyList()
        {
            // Arrange
            TreeNode root = null;

            IList<int> expected = new List<int> { };
            // Act
            IList<int> actual = BinaryTreeTraversal.PreorderTraversalIterative(root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PreorderTraversal_ShouldAddThePreOrderToAList()
        {
            // Arrange
            TreeNode root = new TreeNode(0);
            root.left = new TreeNode(1);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(6);

            IList<int> expected = new List<int> { 0, 1, 3, 4, 2, 5, 6 };
            // Act
            IList<int> actual = BinaryTreeTraversal.PreorderTraversalIterative(root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PreorderTraversal_ShouldAddThePreOrderToAList2()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.left.right.right = new TreeNode(5);

            IList<int> expected = new List<int> { 1, 2, 3, 4, 5 };
            // Act
            IList<int> actual = BinaryTreeTraversal.PreorderTraversalIterative(root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PreorderTraversalRecurse_ShouldAddThePreOrderToAList()
        {
            // Arrange
            TreeNode root = new TreeNode(0);
            root.left = new TreeNode(1);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(6);

            IList<int> expected = new List<int> { 0, 1, 3, 4, 2, 5, 6 };
            // Act
            IList<int> actual = BinaryTreeTraversal.PreorderTraversalRecurse(root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PreorderTraversalRecurse_ShouldAddThePreOrderToAList2()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.left.right.right = new TreeNode(5);

            IList<int> expected = new List<int> { 1, 2, 3, 4, 5 };
            // Act
            IList<int> actual = BinaryTreeTraversal.PreorderTraversalRecurse(root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InorderTraversalIterative_ShouldAddTheInOrderToAList()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.left.right.right = new TreeNode(5);

            IList<int> expected = new List<int> { 3, 2, 4, 5, 1 };
            // Act
            IList<int> actual = BinaryTreeTraversal.InorderTraversalIterative(root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InorderTraversalIterative_ShouldAddTheInOrderToAList2()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.left.right.right = new TreeNode(5);

            IList<int> expected = new List<int> { 3, 2, 4, 5, 1 };
            // Act
            IList<int> actual = BinaryTreeTraversal.InorderTraversalIterative2(root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InorderTraversalRecursion_ShouldAddTheInOrderToAList()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.left.right.right = new TreeNode(5);

            IList<int> expected = new List<int> { 3, 2, 4, 5, 1 };

            // Act
            IList<int> actual = BinaryTreeTraversal.InorderTraversalRecursion(root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PostorderTraversalRecursion()
        {
            // Arrange
            TreeNode root = new TreeNode(6);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(4);
            root.left.right.left = new TreeNode(3);
            root.left.right.right = new TreeNode(5);

            root.right = new TreeNode(7);
            root.right.right = new TreeNode(9);
            root.right.right.left = new TreeNode(8);

            IList<int> expected = new List<int> { 1, 3, 5, 4, 2, 8, 9, 7, 6 };

            // Act
            IList<int> actual = BinaryTreeTraversal.PostorderTraversalRecursion(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelOrder_ShouldReturnALevelOrderSequenceOfBinaryTree()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>());
            expected[0].Add(1);

            // Act
            IList<IList<int>> actual = BinaryTreeTraversal.LevelOrder(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelOrder_ShouldReturnALevelOrderSequenceOfBinaryTree2()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);

            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>());
            expected[0].Add(1);
            expected.Add(new List<int>());
            expected[1].Add(2);

            // Act
            IList<IList<int>> actual = BinaryTreeTraversal.LevelOrder(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelOrder_ShouldReturnALevelOrderSequenceOfBinaryTree3()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.right = new TreeNode(5);

            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>());
            expected[0].Add(1);

            expected.Add(new List<int>());
            expected[1].Add(2);
            expected[1].Add(3);

            expected.Add(new List<int>());
            expected[2].Add(4);
            expected[2].Add(5);

            // Act
            IList<IList<int>> actual = BinaryTreeTraversal.LevelOrder(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelOrder_ShouldReturnALevelOrderSequenceOfBinaryTree4()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.right = new TreeNode(5);
            root.left.left.left = new TreeNode(6);
            root.left.left.right = new TreeNode(7);
            root.right.right.left = new TreeNode(8);
            root.right.right.right = new TreeNode(9);

            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>());
            expected[0].Add(1);

            expected.Add(new List<int>());
            expected[1].Add(2);
            expected[1].Add(3);

            expected.Add(new List<int>());
            expected[2].Add(4);
            expected[2].Add(5);

            expected.Add(new List<int>());
            expected[3].Add(6);
            expected[3].Add(7);
            expected[3].Add(8);
            expected[3].Add(9);

            // Act
            IList<IList<int>> actual = BinaryTreeTraversal.LevelOrder(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelOrder2_ShouldReturnALevelOrderSequenceOfBinaryTree()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>());
            expected[0].Add(1);

            // Act
            IList<IList<int>> actual = BinaryTreeTraversal.LevelOrder2(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelOrder2_ShouldReturnALevelOrderSequenceOfBinaryTree2()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);

            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>());
            expected[0].Add(1);
            expected.Add(new List<int>());
            expected[1].Add(2);

            // Act
            IList<IList<int>> actual = BinaryTreeTraversal.LevelOrder2(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        

        [Fact]
        public void LevelOrder2_ShouldReturnALevelOrderSequenceOfBinaryTree3()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.right = new TreeNode(5);
            root.left.left.left = new TreeNode(6);
            root.left.left.right = new TreeNode(7);
            root.right.right.left = new TreeNode(8);
            root.right.right.right = new TreeNode(9);

            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>());
            expected[0].Add(1);

            expected.Add(new List<int>());
            expected[1].Add(2);
            expected[1].Add(3);

            expected.Add(new List<int>());
            expected[2].Add(4);
            expected[2].Add(5);

            expected.Add(new List<int>());
            expected[3].Add(6);
            expected[3].Add(7);
            expected[3].Add(8);
            expected[3].Add(9);

            // Act
            IList<IList<int>> actual = BinaryTreeTraversal.LevelOrder2(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelOrder2_ShouldReturnALevelOrderSequenceOfBinaryTree4()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.right = new TreeNode(5);

            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>());
            expected[0].Add(1);

            expected.Add(new List<int>());
            expected[1].Add(2);
            expected[1].Add(3);

            expected.Add(new List<int>());
            expected[2].Add(4);
            expected[2].Add(5);

            // Act
            IList<IList<int>> actual = BinaryTreeTraversal.LevelOrder2(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxDepth_ShouldReturnDepthOfABinaryTree()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            int expected = 1;
            // Act
            int actual = BinaryTreeTraversal.MaxDepth(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxDepth_ShouldReturnDepthOfABinaryTree2()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            int expected = 2;
            // Act
            int actual = BinaryTreeTraversal.MaxDepth(root);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxDepth_ShouldReturnDepthOfABinaryTree3()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.right = new TreeNode(5);
            int expected = 3;
            // Act
            int actual = BinaryTreeTraversal.MaxDepth(root);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void MaxDepth_ShouldReturnDepthOfABinaryTree4()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);
            root.right.right.left = new TreeNode(8);
            int expected = 4;
            // Act
            int actual = BinaryTreeTraversal.MaxDepth(root);

            // Assert
            Assert.Equal(expected, actual);
        }        
    }
}
