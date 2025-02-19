using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsAssignment
{
    public class ReverseList
    {
        // Method to reverse an ArrayList
        public static void ReverseArrayList(ArrayList list)
        {
            int left = 0, right = list.Count - 1;
            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }

        // Method to reverse a LinkedList
        public static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (var item in list)
            {
                reversedList.AddFirst(item);
            }
            return reversedList;
        }

        // Method to display an ArrayList
        public static void DisplayArrayList(ArrayList list)
        {
            Console.WriteLine("ArrayList: " + string.Join(", ", list.ToArray()));
        }

        // Method to display a LinkedList
        public static void DisplayLinkedList(LinkedList<int> list)
        {
            Console.WriteLine("LinkedList: " + string.Join(", ", list));
        }

        public static void Main(string[] args)
        {
            // ArrayList Implementation
            ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original ArrayList:");
            DisplayArrayList(arrayList);
            ReverseArrayList(arrayList);
            Console.WriteLine("Reversed ArrayList:");
            DisplayArrayList(arrayList);

            Console.WriteLine();

            // LinkedList Implementation
            LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Original LinkedList:");
            DisplayLinkedList(linkedList);
            LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);
            Console.WriteLine("Reversed LinkedList:");
            DisplayLinkedList(reversedLinkedList);
        }
    }
}
