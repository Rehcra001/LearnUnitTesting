using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionsLibrary.LinkedLists
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; } = null;

        public Node()
        {            
        }

        public Node(int val)
        {
            Value = val;
        }

        public Node(int val, Node next)
        {
            Value = val;
            Next = next;
        }
    }
}
