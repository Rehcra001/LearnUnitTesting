﻿using System.Text;

namespace LeetCodeSolutionsLibrary.LinkedLists
{
    public class SinglyLinkedList
    {
        public ListNode? Head { get; set; } = null;
        public int Count { get; private set; } = 0;

        public SinglyLinkedList()
        {            
        }

        public int Get(int index)
        {
            if (Count > 0 && index < Count)
            {
                if (index == 0)
                {
                    return Head!.Value;
                }

                ListNode current = Head!;
                //Loop until found
                for (int i = 1; i <= index; i++)
                {
                    current = current.Next!;
                }
                return current.Value;;
            }
            else
            {
                return -1;
            }
        }

        public ListNode? GetNode(int index)
        {
            if (Count > 0 && index < Count)
            {
                if (index == 0)
                {
                    return Head!;
                }

                ListNode current = Head!;
                //Loop until found
                for (int i = 1; i <= index; i++)
                {
                    current = current.Next!;
                }
                return current; ;
            }
            else
            {
                return null;
            }
        }

        public void AddAtHead(int val)
        {
            if (Head is null)
            {
                Head = new ListNode(val);
                Count++;
            }
            else
            {
                Head = new ListNode(val, Head);
                Count++;
            }
        }

        public void AddAtTail(int val)
        {
            if (Head is null)
            {
                AddAtHead(val);
            }
            else
            {
                ListNode current = Head;
                while (current.Next is not null)
                {
                    current = current.Next;
                }
                current.Next = new ListNode(val);
                Count++;
            }
            
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
            }
            else if (index == Count)
            {
                AddAtTail(val);
            }
            else if (index < Count)
            {
                //search for node at index
                ListNode current = Head!;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next!;
                }
                current.Next = new ListNode(val, current.Next!);
                Count++;
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (Count > 0 && index < Count)
            {
                if (index == 0)
                {
                    //remove head
                    if (Count == 1)
                    {
                        Head = null;
                        Count--;
                    }
                    else
                    {
                        Head = Head!.Next;
                        Count--;
                    }
                }
                else
                {
                    ListNode current = Head!;
                    for (int i = 1; i < index; i++)
                    {
                        current = current.Next!;
                    }

                    if (current.Next!.Next is null)
                    {
                        current.Next = null;
                    }
                    else
                    {
                        current.Next = current.Next!.Next;
                    }                    
                    Count--;
                }                    
            }            
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            
            if (Head is not null)
            {
                ListNode current = Head;

                for (int i = 0; i < Count; i++)
                {
                    str.Append(current.Value);

                    if (current.Next is not null)
                    {
                        current = current.Next;
                    }                    
                }
                return str.ToString();
            }
            else
            {
                return "";
            }   
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */

}
