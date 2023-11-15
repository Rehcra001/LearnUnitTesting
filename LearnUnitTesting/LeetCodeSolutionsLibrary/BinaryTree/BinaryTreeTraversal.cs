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

        public static void PreorderRecursion(TreeNode root, List<int> preorder)
        {
            if (root is null)
            {
                return;
            }

            preorder.Add(root.val);
            PreorderRecursion(root.left, preorder);
            PreorderRecursion(root.right, preorder);
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

        public static IList<int> PostorderTraversalIterative(TreeNode root)
        {
            List<int> postorder = new List<int>();
            Stack<TreeNode> treeStack = new Stack<TreeNode>();
            HashSet<TreeNode> treeSet = new HashSet<TreeNode>();
            if (root is null)
            {
                return postorder;
            }

            //put root on stack
            treeStack.Push(root);
            if (root.right is not null)
            {
                treeStack.Push(root.right);
            }
            if (root.left is not null)
            {
                treeStack.Push(root.left);
            }

            TreeNode current = root.left;

            while (treeStack.Count > 0)
            {
                while (current is not null)
                {
                    if (current.right is not null && !treeSet.Contains(current.right))
                    {
                        treeStack.Push(current.right);
                    }

                    if (current.left is not null && !treeSet.Contains(current.left))
                    {
                        treeStack.Push(current.left);
                        current = current.left;
                    }
                    else
                    {
                        if (current.right is not null && !treeSet.Contains(current.right))
                        {
                            current = current.right;
                        }
                        else
                        {
                            current = null!;
                        }

                    }
                }
                //current.left is null
                //read value from top of stack
                postorder.Add(treeStack.Peek().val);
                //pop tree node at top of stack and add to visited
                treeSet.Add(treeStack.Pop());
                //set current
                if (treeStack.Count > 0)
                {
                    current = treeStack.Peek();
                }
            }

            return postorder;
        }

        public static IList<int> PostorderTraversalRecursion(TreeNode root)
        {
            List<int> postorder = new List<int>();
            if (root is null)
            {
                return postorder;
            }

            PostorderRecursive(postorder, root);

            return postorder;
        }

        private static void PostorderRecursive(List<int> postorder, TreeNode root)
        {
            if (root is null)
            {
                return;
            }

            //Recurse left
            PostorderRecursive(postorder, root.left);

            //Recurse right
            PostorderRecursive(postorder, root.right);

            //Add to list
            postorder.Add(root.val);
        }

        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> values = new List<IList<int>>();
            if (root is null)
            {
                return values;
            }

            int level = 0;
            List<IList<TreeNode>> nodes = new List<IList<TreeNode>>();

            nodes.Add(new List<TreeNode>());
            nodes[0].Add(root);

            values.Add(new List<int>());
            values[0].Add(root.val);

            level++;

            bool hasChildren = false;
            if (root.left is not null || root.right is not null)
            {
                hasChildren = true;
            }

            while (hasChildren)
            {
                values.Add(new List<int>());
                nodes.Add(new List<TreeNode>());
                hasChildren = false;

                foreach (TreeNode node in nodes[level - 1])
                {
                    //Add left child
                    if (node.left is not null)
                    {
                        //add to node and value
                        nodes[level].Add(node.left);
                        values[level].Add(node.left.val);
                        if (node.left.left is not null || node.left.right is not null)
                        {
                            hasChildren = true;
                        }
                    }
                    //Add right child
                    if (node.right is not null)
                    {
                        //add to node and value
                        nodes[level].Add(node.right);
                        values[level].Add(node.right.val);
                        if (node.right.left is not null || node.right.right is not null)
                        {
                            hasChildren = true;
                        }
                    }
                }
                level++;
            }
            return values;
        }

        public static IList<IList<int>> LevelOrder2(TreeNode root)
        {
            List<IList<int>> values = new List<IList<int>>();
            if (root is null)
            {
                return values;
            }

            int parentCount = 1;
            int childCount = 0;
            Queue<TreeNode> treeQueue = new Queue<TreeNode>();
            treeQueue.Enqueue(root);
            TreeNode current;

            while (treeQueue.Count > 0)
            {
                List<int> level = new List<int>();
                for (int i = 0; i < parentCount; i++)
                {
                    current = treeQueue.Dequeue();
                    if (current.left is not null)
                    {
                        treeQueue.Enqueue(current.left);
                        childCount++;
                    }

                    if (current.right is not null)
                    {
                        treeQueue.Enqueue(current.right);
                        childCount++;
                    }
                    level.Add(current.val);
                }
                values.Add(level);
                parentCount = childCount;
                childCount = 0;
            }

            return values;
        }

        public static int MaxDepth(TreeNode root)
        {
            //Bottom up approach
            if (root is null)
            {
                return 0;
            }

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
