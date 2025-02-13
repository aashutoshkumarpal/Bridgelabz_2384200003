using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques2
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
  
    internal class SortAStackUsingRecursion
    {
            private Node top;

            public SortAStackUsingRecursion()
            {
                top = null;
            }

            public void push(int data)
            {
                Node newNode = new Node(data);

                if (top == null)
                {
                    top = newNode;
                }

                newNode.Next = top;
                top = newNode;
            }
            public int pop()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is Empty");
                }

                int data = top.Data;
                top = top.Next;
                return data;

            }

            public bool IsEmpty()
            {
                return top == null;
            }
            public int peek()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is Empty");
                }
                return top.Data;
            }

             public void SortStack()
             {
                if (!IsEmpty())
                {
                int topElement = pop();
                SortStack();
                InsertInSortedOrder(topElement);
                }
             }

        // Helper function to insert an element in sorted order
            private void InsertInSortedOrder(int item)
            {
                if (IsEmpty() || peek() <= item)
                {
                push(item);
                return;
                }

                int temp = pop();
                InsertInSortedOrder(item);
                push(temp);
            }

        // Display stack elements
        public void PrintStack()
        {
            Node current = top;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}
