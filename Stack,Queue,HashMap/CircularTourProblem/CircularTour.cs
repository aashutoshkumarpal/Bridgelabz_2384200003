using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularTourProblem
{
    // Node class for LinkedList-based Queue
    public class Node
    {
        public int Index;
        public int Petrol;
        public int Distance;
        public Node Next;

        public Node(int index, int petrol, int distance)
        {
            Index = index;
            Petrol = petrol;
            Distance = distance;
            Next = null;
        }
    }

    // Queue Implementation Using LinkedList
    public class Queue
    {
        private Node front, rear;

        public Queue()
        {
            front = rear = null;
        }

        // Enqueue: Add a petrol pump to the queue
        public void Enqueue(int index, int petrol, int distance)
        {
            Node newNode = new Node(index, petrol, distance);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        // Dequeue: Remove a petrol pump from the front
        public void Dequeue()
        {
            if (front != null)
            {
                front = front.Next;
                if (front == null) rear = null;
            }
        }

        // Peek the front element's index
        public int FrontIndex()
        {
            return front != null ? front.Index : -1;
        }

        // Check if queue is empty
        public bool IsEmpty()
        {
            return front == null;
        }
    }

    // Circular Tour Solver
    public class CircularTour
    {
        public int FindStartingPump(int[] petrol, int[] distance)
        {
            int n = petrol.Length;
            int totalSurplus = 0, currSurplus = 0, startIndex = 0;
            Queue queue = new Queue();

            for (int i = 0; i < n; i++)
            {
                totalSurplus += petrol[i] - distance[i];
                currSurplus += petrol[i] - distance[i];

                // If we run out of petrol, reset startIndex and clear queue
                if (currSurplus < 0)
                {
                    startIndex = i + 1;
                    currSurplus = 0;
                }

                queue.Enqueue(i, petrol[i], distance[i]);
            }

            return totalSurplus >= 0 ? startIndex : -1;
        }
    }
}
