
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class BookPriceSorter
    {
        public void InputMethod()
        {
            Console.Write("Enter the number of book prices: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] bookPrices = new double[n];

            Console.WriteLine("Enter book prices:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Price {i + 1}: ");
                bookPrices[i] = Convert.ToDouble(Console.ReadLine());
            }

            MergeSort(bookPrices, 0, n - 1);
            DisplaySortedPrices(bookPrices);
        }

        private void MergeSort(double[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private void Merge(double[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            double[] leftArr = new double[n1];
            double[] rightArr = new double[n2];

            for (int i = 0; i < n1; i++)
                leftArr[i] = arr[left + i];

            for (int j = 0; j < n2; j++)
                rightArr[j] = arr[mid + 1 + j];

            int x = 0, y = 0, k = left;

            while (x < n1 && y < n2)
            {
                if (leftArr[x] <= rightArr[y])
                {
                    arr[k] = leftArr[x];
                    x++;
                }
                else
                {
                    arr[k] = rightArr[y];
                    y++;
                }
                k++;
            }

            while (x < n1)
            {
                arr[k] = leftArr[x];
                x++;
                k++;
            }

            while (y < n2)
            {
                arr[k] = rightArr[y];
                y++;
                k++;
            }
        }

        private void DisplaySortedPrices(double[] arr)
        {
            Console.WriteLine("\nSorted Book Prices:");
            foreach (double price in arr)
            {
                Console.Write(price + " ");
            }
            Console.WriteLine();
        }
    }
}
