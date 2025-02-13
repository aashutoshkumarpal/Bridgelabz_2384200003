using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueHashing
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data= data;
            Next = null;
        }
    }

    public class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        public void push(int data)
        { 
            Node newNode = new Node(data);

            if(top == null)
            {
                top = newNode;
            }

            newNode.Next = top;
            top = newNode;
        }
        public int pop() 
        { 
            if(IsEmpty())
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
    }
    internal class ImplementAQueueUsingStacks
    {
        private Stack s1;
        private Stack s2;

        public ImplementAQueueUsingStacks()
        {
            s1 = new Stack();
            s2 = new Stack();
        }

        public void Enqueue(int data)
        { 
            s1.push(data);
        }

        public int Denqueue()
        {
            if (IsEmpty()) 
            {
                Console.WriteLine("queue is Empty ");
            }

            if (s2.IsEmpty())
            {
                while (!s1.IsEmpty()) 
                {
                    s2.push(s1.pop());
                }
            }

            return s2.pop();
        }

        public bool IsEmpty()
        {
            return s1.IsEmpty() && s2.IsEmpty();
        }
    }
}
