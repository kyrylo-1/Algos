using System;
using System.Collections.Generic;
using Common;

namespace BubbleSort
{
    /// <summary>
    /// Class contains variations of bubble sort ascending order algorithm. Complexity: O(n^2)
    /// </summary>
    class EntryBubbleSort
    {
        static void Main(string[] args)
        {
            var array = new int[] { 3, 9, 1, 34, 9, 10 };
            Console.WriteLine("Before sorting");
            array.WriteEachElement();

            Console.WriteLine("\n\nAfter BubbleSortAscending");
            SortFromStart(array);
            array.WriteEachElement();

            array = new int[] { 3, 9, 1, 34, 9, 10 };
            Console.WriteLine("\n\nAfter SortFromStartIMP");
            SortFromStartIMP(array);
            array.WriteEachElement();

            array = new int[] { 3, 9, 1, 34, 9, 10 };
            Console.WriteLine("\n\nAfter SortFromEndIMP");
            SortFromEndIMP(array);
            array.WriteEachElement();
        }

        /// <summary>
        /// Ascendingly sort array from the start without optimization. 
        /// </summary>
        public static void SortFromStart(int[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (array[j + 1] < array[j])
                        ArrayTools.Swap<int>(array, j + 1, j);
                }
            }
        }

        /// <summary>
        /// Ascendingly sort array from the end without optimization. 
        /// </summary>
        public static void SortFromEnd(int[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = len - 1; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                        ArrayTools.Swap<int>(array, j, j - 1);
                }
            }
        }

        /// <summary>
        /// Sort array from the end with optimization. Could be quicker in 2 times than non-optimize.
        /// Considered as classic bubble sort algorithm
        /// </summary>
        public static void SortFromEndIMP(int[] array)
        {
            bool isSwapped = true;
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                isSwapped = false;
                for (int j = len - 1; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        ArrayTools.Swap(array, j, j - 1);
                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                    break;
            }
        }

        /// <summary>
        /// Sort array from the end with optimization. Could be quicker in 2 times than non-optimize
        /// </summary>
        public static void SortFromStartIMP(int[] array)
        {
            bool isSwapped = true;
            int len = array.Length;
            for (int i = 0; i < len - 1; i++)
            {
                isSwapped = false;
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        ArrayTools.Swap<int>(array, j + 1, j);
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                    break;
            }
        }
    }
}
