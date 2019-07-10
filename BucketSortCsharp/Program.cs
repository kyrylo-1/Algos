using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BucketSortCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 37, 44, 63, 54, 12, 58, 32 };
            Console.WriteLine("Before sorting");
            array.WriteEachElement();

            Console.WriteLine("\n\nAfter Bucketsort");
            List<int> listSorted = new Program().Bucketsort(array);
            listSorted.WriteEachElement();
        }

        //arr = new int[] { 37, 44, 63, 54, 12, 58, 32 };
        public List<int> Bucketsort(int[] arr)
        {
            var result = new List<int>();

            //Determine how many buckets you want to create, in this case, the arr.length buckets. 
            int maxVal = arr.Max();
            int minVal = arr.Min();

            //Find rangeStep
            int range = maxVal - minVal;
            int rangeStep = 1;

            while (arr.Length * rangeStep < range)
                rangeStep++;


            List<int>[] buckets = new List<int>[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                buckets[i] = new List<int>();

            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < arr.Length; i++)
            {
                int bucketChoice = (arr[i] - minVal) / rangeStep;
                buckets[bucketChoice].Add(arr[i]);
            }

            //Sort each bucket and add it to the result List
            //Each sublist is sorted using Bubblesort, but you could substitute any sorting algo you would like
            for (int i = 0; i < arr.Length; i++)
            {
                int[] temp = InsertionSort(buckets[i]);
                result.AddRange(temp);
            }
            return result;
        }

        public static int[] InsertionSort(List<int> input)
        {
            for (int i = 1; i < input.Count; i++)
            {
                int iElement = input[i];
                int j = i;

                while (j > 0 && input[j - 1] > iElement)
                {
                    input[j] = input[j - 1];
                    j--;
                }

                input[j] = iElement;
            }
            return input.ToArray();
        }
    }
}
