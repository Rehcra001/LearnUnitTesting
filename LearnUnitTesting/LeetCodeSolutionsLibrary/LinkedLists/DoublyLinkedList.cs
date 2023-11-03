using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionsLibrary.LinkedLists
{
    public class DoublyLinkedList
    {
        public DoubleListNode? Head { get; set; } = null;
        public int Count { get; private set; } = 0;

        /// <summary>
        /// Get the value of node at index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Get(int index)
        {
            if (Count > 0 && index < Count)
            {
                if (index == 0)
                {
                    return Head!.Value;
                }

                DoubleListNode node = Head!;

                for (int i = 1; i <= index; i++)
                {
                    node = node.Next;
                }
                return node.Value;
            }

            return -1;
        }

        /// <summary>
        /// Get the node at index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DoubleListNode? GetNode(int index)
        {
            if (Count > 0 && index < Count)
            {
                if (index == 0)
                {
                    return Head;
                }

                DoubleListNode node = Head!;

                for (int i = 1; i <= index; i++)
                {
                    node = node.Next;
                }
                return node;
            }

            return null;
        }

        /// <summary>
        /// Add a node at the start of this list
        /// </summary>
        /// <param name="val"></param>
        public void AddAtHead(int val)
        {
            if (Head is null)
            {
                //nothing in the list yet
                Head = new DoubleListNode(val);
                Count++;
            }
            else
            {
                //Head exists add to Head.Previous
                Head.Previous = new DoubleListNode(val, null!, Head);
                Head = Head.Previous;
                Count++;
            }
        }

        /// <summary>
        /// Add a node to the end of this list
        /// </summary>
        /// <param name="val"></param>
        public void AddAtTail(int val)
        {
            if (Head is null)
            {
                //nothing in the list
                AddAtHead(val);
            }
            else
            {
                DoubleListNode node = GetNode(Count - 1)!;
                node.Next = new DoubleListNode(val, node, null!);
                Count++;
            }
        }

        /// <summary>
        /// Insert a node at the index of this list
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
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
            else
            {
                DoubleListNode node = GetNode(index)!;
                if (node is not null)
                {
                    DoubleListNode newNode = new DoubleListNode(val, node.Previous, node);
                    node.Previous = newNode;
                    newNode.Previous.Next = newNode;
                    node = null;
                    Count++;
                }
            }
        }

        /// <summary>
        /// Delete a node at index of this list
        /// </summary>
        /// <param name="index"></param>
        public void DeleteAtIndex(int index)
        {
            if (Count > 0 && index < Count)
            {
                if (index == 0)
                {
                    //Delete head
                    DoubleListNode node = Head!.Next;
                    Head.Next = null!;
                    Head = node;
                    Count--;
                }
                else if (index == Count - 1)
                {
                    DoubleListNode node = GetNode(index)!;
                    node.Previous.Next = null!;
                    Count--;
                }
                else
                {
                    DoubleListNode node = GetNode(index)!;
                    node.Previous.Next = node.Next;
                    node.Next.Previous = node.Previous;
                    node = null!;
                    Count--;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            if (Head is not null)
            {
                DoubleListNode node = Head;

                for (int i = 0; i < Count; i++)
                {
                    str.Append(node.Value);

                    if (node.Next is not null)
                    {
                        node = node.Next;
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
}
