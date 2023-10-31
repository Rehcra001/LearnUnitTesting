using System.Collections.Generic;

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

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            // get the lengths of list A starting at headA and
            // list B starting at headB
            // each list will be at least one long
            int countA = 1;
            int countB = 1;
            ListNode nodeA = headA;
            ListNode nodeB = headB;

            while (nodeA.Next is not null)
            {
                nodeA = nodeA.Next;
                countA++;
            }

            while (nodeB.Next is not null)
            {
                nodeB = nodeB.Next;
                countB++;
            }

            //reset
            nodeA = headA;
            nodeB = headB;
            
            // Check for longest
            if (countA > countB)
            {
                //move until countA == countB
                while (countA > countB)
                {
                    nodeA = nodeA.Next!;
                    countA--;
                }

            }
            else if (countB > countA)
            {
                //move until countA == countB
                while (countB > countA)
                {
                    nodeB = nodeB.Next!;
                    countB--;
                }
            }

            //search for intersection
            while (countA > 0)
            {                
                if (nodeA == nodeB)
                {
                    return nodeA;
                }
                else if (nodeA.Next == null || nodeB.Next == null)
                {
                    return null!;
                }
                nodeA = nodeA.Next;
                nodeB = nodeB.Next;
                countA--;
            }

            return null!;
        }

        public static (ListNode, ListNode) CreateIntersection(int lenA, int lenB, int lenRest = 0)
        {
            //Create two singly linked lists
            Random random = new Random();

            SinglyLinkedList listA = new SinglyLinkedList();
            //Add node to the tail of linked list 
            for (int i = 0; i < lenA; i++)
            {
                listA.AddAtTail(random.Next(0, 101));
            }

            SinglyLinkedList listB = new SinglyLinkedList();
            //Add node to the tail of linked list 
            for (int i = 0; i < lenB; i++)
            {
                listB.AddAtTail(random.Next(0, 101));
            }

            //If lenRest > 0 create a third linked list
            SinglyLinkedList listRest = new SinglyLinkedList();
            if (lenRest > 0)
            {
                for (int i = 0; i < lenRest; i++)
                {
                    listRest.AddAtTail(random.Next(0, 101));
                }

                //Join to the first two lists
                ListNode a = listA.GetNode(listA.Count - 1)!;
                a.Next = listRest.Head!;

                ListNode b = listB.GetNode(listB.Count - 1)!;
                b.Next = listRest.Head!;
            }

            return (listA.Head!, listB.Head!);
        }
    }
}
