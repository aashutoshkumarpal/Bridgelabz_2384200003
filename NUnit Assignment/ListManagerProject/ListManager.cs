using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManagerProject
{
    public class ListManager
    {
        // Adds an element to the list.
        public void AddElement(List<int> list, int element)
        {
            list.Add(element);
        }

        // Removes an element from the list if it exists.
        public void RemoveElement(List<int> list, int element)
        {
            list.Remove(element);
        }

        // Returns the size of the list.
        public int GetSize(List<int> list)
        {
            return list.Count;
        }
    }
}