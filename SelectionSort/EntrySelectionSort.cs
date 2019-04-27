using System;
using Common;

namespace SelectionSort
{
    /// <summary>
    /// Class contains variations of selection sort.Time Complexity: O(n2) as there are two nested loops.
    /// Auxiliary Space: O(1)
    /// </summary>
    /// <remarks\>
    /// The selection sort algorithm sorts an array by repeatedly finding the minimum
    /// element (considering ascending order) from unsorted part and putting it at the beginning. 
    /// The algorithm maintains two subarrays in a given array.
    /// The good thing about selection sort is it never makes more than O(n) swaps
    /// and can be useful when memory write is a costly operation.
    /// </remarks>
    class EntrySelectionSort
    {
        static void Main(string[] args)
        {
            var array = new int[] { 3, 9, 1, 34, 9, 10, -3 };
            Console.WriteLine("Before sorting");
            array.WriteEachElement();

            Console.WriteLine("\n\nAfter SelectionSort");
            Sort(array);
            array.WriteEachElement();
        }

        public static void Sort(int[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                int min = int.MaxValue;
                int jMin = i;
                for (int j = i; j < len; j++)
                {
                    if (min > array[j])
                    {
                        min = array[j];
                        jMin = j;
                    }
                }

                if (i != jMin)
                    ArrayTools.Swap<int>(array, i, jMin);
            }
        }
    }
}
