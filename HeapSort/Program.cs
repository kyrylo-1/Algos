using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace HeapSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 2, 7, 3, 6, 1, 4 };

            Console.WriteLine("Before sorting");
            arr.WriteEachElement();

            Console.WriteLine("\n\nAfter Countsort");
            arr = new Program().HeapSort(arr);

            arr.WriteEachElement();
        }

        public int[] HeapSort(int[] arr)
        {
            int heapSize = arr.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(arr, heapSize, p);

            for (int i = arr.Length - 1; i > 0; i--)
            {
                ArrayTools.Swap(arr, i, 0);

                heapSize--;
                MaxHeapify(arr, heapSize, 0);
            }

            return arr;
        }

        private void MaxHeapify(int[] arr, int heapSize, int i)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int largest;
            if (left < heapSize && arr[left] > arr[i])
                largest = left;
            else
                largest = i;

            if (right < heapSize && arr[right] > arr[largest])
                largest = right;


            if (largest != i)
            {
                ArrayTools.Swap(arr, i, largest);

                MaxHeapify(arr, heapSize, largest);
            }
        }
    }
}
