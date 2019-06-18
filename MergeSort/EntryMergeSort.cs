using System;
using Common;

namespace MergeSort
{
    class EntryMergeSort
    {
        static void Main(string[] args)
        {
            var array = new int[] { 3, 9, 1, 34, 9, 10, -3 };
            Console.WriteLine("Before sorting");
            array.WriteEachElement();

            //Console.WriteLine("\n\nAfter SelectionSort");
            //MergeSorter.Sort(array);
            //array.WriteEachElement();

            Console.WriteLine("\n\nAfter BottomUp merge sort");
            MergeSorterBottomUp.Sort(array);
            array.WriteEachElement();
            Console.ReadLine();
        }

    }
}
