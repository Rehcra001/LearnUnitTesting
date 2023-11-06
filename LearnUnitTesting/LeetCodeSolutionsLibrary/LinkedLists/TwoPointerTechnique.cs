using System.Collections.Generic;

namespace LeetCodeSolutionsLibrary.LinkedLists
{
    public static class TwoPointerTechnique
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode Next;
         *     public ListNode(int x) {
         *         val = x;
         *         Next = null;
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
        public static ListNode? DetectCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast is not null && fast.Next is not null)
            {
                slow = slow.Next!;
                fast = fast.Next.Next!;
                if (fast == slow)
                {
                    break;
                }
            }

            if (fast == null || fast.Next == null)
            {
                return null;
            }
            else
            {
                slow = head;
                while (fast != slow)
                {
                    slow = slow.Next!;
                    fast = fast.Next!;
                }
                return slow;
            }
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

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode lead = head;
            ListNode trail = head;

            for (int i = 1; i < n; i++)
            {
                lead = lead.Next!;
            }

            if (lead.Next is null)
            {
                return head.Next!;
            }
            else
            {
                lead = lead.Next;
            }

            while (lead.Next is not null)
            {
                lead = lead.Next;
                trail = trail.Next!;
            }
            trail.Next = trail.Next!.Next;
            return head;
        }
        public static ListNode ReverseList(ListNode head)
        {
            //Iterative solution

            ListNode? last = head;
            ListNode current;

            while (last is not null && last.Next is not null)
            {
                current = last.Next;
                last.Next = last.Next.Next;
                if (current is not null)
                {
                    current.Next = head;
                    head = current;
                }
            }
            return head;
        }
        public static ListNode ReverseList2(ListNode head)
        {
            //Recursive solution
            //Base case
            if (head is null)
            {
                return head;
            }

            return head;
        }

        public static ListNode RemoveElements(ListNode head, int val)
        {

            while (head is not null && head.Value == val)
            {
                head = head.Next;
            }

            if (head is not null)
            {
                ListNode current = head;
                while (current.Next is not null)
                {
                    if (current.Next.Value == val)
                    {
                        current.Next = current.Next.Next;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

            }

            return head;
        }
        public static ListNode? CreateCycle(int listLength, int cycleIndex = 0)//cycleIndex = -1 has no cycle
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

            // set the last list nodes Next property = a list node at cycleIndex
            if (cycleIndex != -1)
            {
                //Create cycle
                ListNode tail = linkedList.GetNode(linkedList.Count - 1)!;
                ListNode cycleNode = linkedList.GetNode(cycleIndex)!;
                tail!.Next = cycleNode;
            }

            return linkedList.Head;
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

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 is null && list2 is null)
            {
                return null;
            }
            if (list1 is null && list2 is not null)
            {
                return list2;
            }
            if (list1 is not null && list2 is null)
            {
                return list1;
            }

            //At this point both lists are not null
            ListNode head;
            if (list1.Value <= list2.Value)
            {
                head = list1;
                list1 = list1.Next;
            }
            else
            {
                head = list2;
                list2 = list2.Next;
            }
            ListNode current = head;

            while (list1 is not null || list2 is not null)
            {
                if (list1 is not null && list2 is null)
                {
                    while (list1 is not null)
                    {
                        current.Next = list1;
                        current = current.Next;
                        list1 = list1.Next;
                    }
                    return head;
                }

                while (list1 is not null && list1.Value <= list2.Value)
                {
                    current.Next = list1;
                    current = current.Next;
                    list1 = list1.Next;
                }

                if (list2 is not null && list1 is null)
                {
                    while (list2 is not null)
                    {
                        current.Next = list2;
                        current = current.Next;
                        list2 = list2.Next;
                    }
                    return head;
                } 

                while (list2 is not null && list2.Value < list1.Value)
                {
                    current.Next = list2;
                    current = current.Next;
                    list2 = list2.Next;
                }

                
            }            

            return head;
        }
    }
}
