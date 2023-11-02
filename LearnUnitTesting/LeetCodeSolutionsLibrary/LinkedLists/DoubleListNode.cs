using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionsLibrary.LinkedLists
{
    public class DoubleListNode
    {
        public int Value { get; set; }
        public DoubleListNode Previous { get; set; }
        public DoubleListNode Next { get; set; }

        public DoubleListNode(int value, DoubleListNode previous = null, DoubleListNode next = null)
        {
            Value = value;
            Previous = previous;
            Next = next;
        }
    }
}
