using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindowMaximum
{
    // Node class for LinkedList-based Deque
    public class Node
    {
        public int Index;
        public Node Next;
        public Node Prev;

        public Node(int index)
        {
            Index = index;
            Next = null;
            Prev = null;
        }
    }

    // Deque (Double-Ended Queue) Implementation Using LinkedList
    public class Deque
    {
        private Node front, rear;

        public Deque()
        {
            front = rear = null;
        }

        // Add to rear
        public void PushBack(int index)
        {
            Node newNode = new Node(index);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                newNode.Prev = rear;
                rear = newNode;
            }
        }

        // Remove from front
        public void PopFront()
        {
            if (front != null)
            {
                front = front.Next;
                if (front == null) rear = null;
                else front.Prev = null;
            }
        }

        // Remove from rear
        public void PopBack()
        {
            if (rear != null)
            {
                rear = rear.Prev;
                if (rear == null) front = null;
                else rear.Next = null;
            }
        }

        // Get front index
        public int Front()
        {
            return front != null ? front.Index : -1;
        }

        // Get rear index
        public int Rear()
        {
            return rear != null ? rear.Index : -1;
        }

        // Check if deque is empty
        public bool IsEmpty()
        {
            return front == null;
        }
    }

    // Sliding Window Maximum Solver
    public class SlidingWindowMax
    {
        public int[] FindMaxSlidingWindow(int[] arr, int k)
        {
            int n = arr.Length;
            if (n == 0 || k > n) return new int[0];

            int[] result = new int[n - k + 1];
            Deque deque = new Deque();
            int resultIndex = 0;

            for (int i = 0; i < n; i++)
            {
                // Remove elements outside the current window
                if (!deque.IsEmpty() && deque.Front() <= i - k)
                {
                    deque.PopFront();
                }

                // Remove elements smaller than the current element from rear
                while (!deque.IsEmpty() && arr[deque.Rear()] <= arr[i])
                {
                    deque.PopBack();
                }

                // Add current index at the rear
                deque.PushBack(i);

                // Start recording max values once we process the first k elements
                if (i >= k - 1)
                {
                    result[resultIndex++] = arr[deque.Front()];
                }
            }

            return result;
        }
    }
}
