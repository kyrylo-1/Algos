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
            var array = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };
            Console.WriteLine("Before sorting");
            array.WriteEachElement();

            Console.WriteLine("\n\nAfter QuickSort");
            //Sort(array);

            QuickSortIterative(array);
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
            int pivotNumb = ar[lo]; // maybe ar[new Random().Next(lo, hi + 1)];
            int iLeft = lo - 1; // Initialize left index
            int iRight = hi + 1; // Initialize right index

            while (true)
            {
                //increment the 'left' index until array with 'left' index less or equal the pivot     
                do
                {
                    iLeft++;
                }
                while (ar[iLeft] < pivotNumb);

                //decrement the 'right' index until array with 'right' index more or equal the pivot
                do
                {
                    iRight--;
                }
                while (ar[iRight] > pivotNumb);

                if (iLeft < iRight)
                    ArrayTools.Swap(ar, iLeft, iRight);

                else
                    return iRight;
            }
        }

        private static void QuickSortIterative(int[] arr)
        {
            var stack = new Stack<Pair>();

            int iLow = 0;
            int iHigh = arr.Length - 1;

            stack.Push(new Pair(iLow, iHigh));

            while (stack.Any())
            {
                iLow = stack.Peek().lowIndex;
                iHigh = stack.Peek().highIndex;
                stack.Pop();

                if (iLow >= iHigh)
                    continue;

                int pi = Partition(arr, iLow, iHigh);

                stack.Push(new Pair(iLow, pi));
                stack.Push(new Pair(pi + 1, iHigh));
            }
        }

        private class Pair
        {
            internal readonly int lowIndex;
            internal readonly int highIndex;

            public Pair(int lowIndex, int highIndex)
            {
                this.lowIndex = lowIndex;
                this.highIndex = highIndex;
            }
        }
    }
}
