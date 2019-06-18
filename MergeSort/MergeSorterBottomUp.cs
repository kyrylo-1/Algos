using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSorterBottomUp
    {
        public static void Sort(int[] input)
        {
            int len = input.Length;

            for (int currSize = 1; currSize <= len - 1; currSize = 2 * currSize)
            {
                for (int left = 0; left < len - 1; left += 2 * currSize)
                {
                    int mid = left + currSize - 1;

                    int high = Math.Min(
                        left + 2 * currSize - 1,
                        len - 1);

                    Merge(input, left, mid, high);
                }
            }
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;

            int[] tmp = new int[(high - low) + 1];
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
            for (int i = 0; i < tmp.Length; i++)
                input[low + i] = tmp[i];
        }
    }
}
