using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace QuickSort
{
    /// <summary>
    /// Time complexity: Average: n log(n)); Worst n^2
    /// Space complexity: O(log(n))
    /// </summary>
    [System.Runtime.InteropServices.Guid("5A7AC3FC-FB07-4DBF-88A8-352B5D573035")]
    class EntryQuickSort
    {
        static void Main(string[] args)
        {
            var array = new int[] { 3, 9, 1, 34, 9, 10, -3 };
            Console.WriteLine("Before sorting");
            array.WriteEachElement();

            Console.WriteLine("\n\nAfter QuickSort");
            Sort(array);
            array.WriteEachElement();
        }

        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int lo, int hi)
        {
            if (lo < hi)
            {
                //partial index
                int pi = Partition(array, lo, hi);

                Sort(array, lo, pi);
                Sort(array, pi + 1, hi);
            }
        }

        // Hoare partition
        private static int Partition(int[] ar, int lo, int hi)
        {
            //int pivot = ar[lo];
            //int pivot = ar[new Random().Next(lo, hi + 1)];
            int pivot = ar[lo];
            int left = lo - 1; // Initialize left index
            int right = hi + 1; // Initialize right index

            while (true)
            {
                //increment the 'left' index until array with 'left' index less or equal the pivot     
                do
                {
                    left++;
                }
                while (ar[left] < pivot);

                //decrement the 'right' index until array with 'right' index more or equal the pivot
                do
                {
                    right--;
                }
                while (ar[right] > pivot);

                if (left < right)
                    ArrayTools.Swap(ar, left, right);

                else
                    return right;
            }
        }


    }
}
