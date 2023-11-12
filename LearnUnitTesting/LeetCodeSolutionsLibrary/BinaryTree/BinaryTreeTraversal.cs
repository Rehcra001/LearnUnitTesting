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

        public static IList<int> InorderTraversalIterative(TreeNode root)
        {
            List<int> inorder = new List<int>();
            if (root is null)
            {
                return inorder;
            }

            Stack<TreeNode> treeStack = new Stack<TreeNode>();
            HashSet<TreeNode> visited = new HashSet<TreeNode>();
            TreeNode current;
            //push
            treeStack.Push(root);

            while (treeStack.Count > 0)
            {
                current = treeStack.Peek();

                if (current.left is not null && !visited.Contains(current.left))
                {
                    treeStack.Push(current.left);
                }
                else
                {
                    visited.Add(treeStack.Pop());
                    inorder.Add(current.val);

                    if (current.right is not null)
                    {
                        treeStack.Push(current.right);
                    }
                }
            }

            return inorder;
        }

        public static IList<int> InorderTraversalIterative2(TreeNode root)
        {
            List<int> inorder = new List<int>();
            if (root is null)
            {
                return inorder;
            }

            Stack<TreeNode> treeStack = new Stack<TreeNode>();
            TreeNode current = root;

            treeStack.Push(current);
            while (treeStack.Count > 0)
            {
                while (current is not null)
                {
                    if (current.left is not null)
                    {
                        treeStack.Push(current.left);
                    }
                    current = current.left;
                }

                if (current is null && treeStack.Count > 0)
                {
                    current = treeStack.Pop();
                    inorder.Add(current.val);
                    current = current.right;
                    if (current is not null)
                    {
                        treeStack.Push(current);
                    }
                }
            }
            return inorder;
        }

        public static IList<int> InorderTraversalRecursion(TreeNode root)
        {
            List<int> inorder = new List<int>();
            if (root is null)
            {
                return inorder;
            }

            InorderRecurse(inorder, root);

            return inorder;
        }

        private static void InorderRecurse(List<int> inorder, TreeNode root)
        {
            if (root is null)
            {
                return;
            }

            //keep going left until null
            InorderRecurse(inorder, root.left);

            //record
            inorder.Add(root.val);

            //go right
            InorderRecurse(inorder, root.right);
        }
    }
}
