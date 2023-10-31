namespace LeetCodeSolutionsLibrary.LinkedLists
{
    public static class TwoPointerTechnique
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int x) {
         *         val = x;
         *         next = null;
         *     }
         * }
         */
        public static bool HasCycle(ListNode head)
        {
            if (head is null)
            {
                return false;
            }

            ListNode slow = head;
            ListNode fast = head;

            while (fast.Next is not null && fast.Next.Next is not null)
            {
                //fast moves twice as fast as slow
                for (int i = 1; i <= 2; i++)
                {
                    fast = fast.Next!;
                    if (fast == slow)
                    {
                        return true;
                    }
                }
                slow = slow.Next!;
            }
            return false;
        }

        public static ListNode? CreateCycle(int listLength, int cycleIndex = 0)
        {
            if (listLength == 0)
            {
                return null;
            }

            Random random = new Random();

            SinglyLinkedList linkedList = new SinglyLinkedList();

            //Add list to the tail of linked list 
            for (int i = 0; i < listLength; i++)
            {
                linkedList.AddAtTail(random.Next(0, 101));
            }

            // set the last list nodes next property = a list node at cycleIndex
            if (cycleIndex != -1)
            {
                //Create cycle
                ListNode tail = linkedList.GetNode(linkedList.Count - 1)!;
                ListNode cycleNode = linkedList.GetNode(cycleIndex)!;
                tail!.Next = cycleNode;
            }

            return linkedList.Head;
        }
    }
}
