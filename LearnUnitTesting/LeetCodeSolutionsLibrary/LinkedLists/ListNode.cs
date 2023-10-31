using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionsLibrary.LinkedLists
{
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode? Next { get; set; } = null;

        public ListNode()
        {            
        }

        public ListNode(int val)
        {
            Value = val;
        }

        public ListNode(int val, ListNode next)
        {
            Value = val;
            Next = next;
        }
    }
}
