using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionsLibrary.BinaryTree
{
    public static class BinaryTreeTraversal
    {
        public static IList<int> PreorderTraversalIterative(TreeNode root)
        {
            List<int> preOrder = new List<int>();

            if (root is null)
            {
                return preOrder;
            }

            Stack<TreeNode> treeStack = new Stack<TreeNode>();
            treeStack.Push(root);

            while (treeStack.Count > 0)
            {
                TreeNode current = treeStack.Peek();
                preOrder.Add(treeStack.Pop().val);

                //push the right
                if (current.right is not null)
                {
                    treeStack.Push(current.right);
                }

                //push the left
                if (current.left is not null)
                {
                    treeStack.Push(current.left);
                }
            }

            return preOrder;
        }
        public static IList<int> PreorderTraversalRecurse(TreeNode root)
        {
            List<int> preorder = new List<int>();
            if (root is null)
            {
                return preorder;
            }

            PreorderRecursion(root, preorder);
            return preorder;
        }

        public static void PreorderRecursion( TreeNode root, List<int> preorder)
        {
            if (root is null)
            {
                return;
            }

            preorder.Add(root.val);            
            PreorderRecursion( root.left, preorder);
            PreorderRecursion( root.right, preorder);
        }
    }
}
