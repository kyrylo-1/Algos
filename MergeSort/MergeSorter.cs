using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace MergeSort
{
    /// <summary>
    /// Merge sort algorithm in ascending order
    /// </summary>
    public class MergeSorter
    {

        public static void Sort(int[] input)
        {
            Sort(input, 0, input.Length - 1);
        }

        static int InMerge = 0;
        private static void Sort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
                Sort(input, low, middle);
                Sort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {
            InMerge++;

            int left = low;
            int right = middle + 1;

            //temporary array
            int[] tmp = new int[(high - low) + 1];
            Console.WriteLine("\nTmp:");


            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left++;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right++;
                }
                tmpIndex++;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left++;
                    tmpIndex++;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right++;
                    tmpIndex++;
                }
            }
            ArrayTools.WriteEachElement(tmp);
            for (int i = 0; i < tmp.Length; i++)
                input[low + i] = tmp[i];
        }
    }
}
