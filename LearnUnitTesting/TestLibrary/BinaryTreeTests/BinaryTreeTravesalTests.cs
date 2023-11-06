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
    }
}
